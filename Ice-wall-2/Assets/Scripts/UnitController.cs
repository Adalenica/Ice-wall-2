using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
	public class UnitController: MonoBehaviour
	{
		[SerializeField] private UnitData _unitData;	
		
		private Wall _wall;
		private Vector2 _spawnPosition;

		[ContextMenu("Attack")]
		public void Attack()
		{
			Debug.Log("Attack");
		}
		
		public void Start()
		{
			RandomisePosition();
			_wall = FindFirstObjectByType<Wall>();
			if (_wall != null)
			{
				StartCoroutine(UnitMeleeAttackRoutine());
			}
			else
			{
				Debug.Log("No Wall");
			}
		}

		private void RandomisePosition()
		{
			float minX = -7f;
			float maxX = 5f;

			 _spawnPosition = new Vector2(Random.Range(minX, maxX), -4f);
			transform.position = _spawnPosition;
		}

		private IEnumerator UnitMeleeAttackRoutine()
		{
			yield return MoveToWall();
			yield return PerformAttack();
			yield return ReturnToOrigin();
			yield return WaitForNextAttack();
			StartCoroutine(UnitMeleeAttackRoutine());
		}

		private IEnumerator WaitForNextAttack()
		{
			Debug.Log("Waiting for attack");
			yield return new WaitForSeconds(_unitData.AttackCooldown);
		}

		private IEnumerator ReturnToOrigin()
		{
			Debug.Log("Return to origin");
			var position = transform.position;
			while (position.x > _spawnPosition.x)
			{
				position.x -= _unitData.Speed * Time.deltaTime;
				transform.position = position;
				yield return new WaitForEndOfFrame();
			}
			yield return new WaitForSeconds(1f);
		}

		private IEnumerator PerformAttack()
		{
			_wall.TakeDamage(_unitData.Strength);
			yield return new WaitForSeconds(1f);
		}

		private IEnumerator MoveToWall()
		{
			Debug.Log("MoveToWall");
			var wallPosition = _wall.transform.position;
			var position = transform.position;
			while(position.x < wallPosition.x-1)
			{
				position.x += _unitData.Speed * Time.deltaTime;
				transform.position = position;
				yield return new WaitForEndOfFrame();
			}
			transform.position = new Vector3(wallPosition.x-1, transform.position.y, transform.position.z);
			yield return new WaitForSeconds(1f);
		}
	}
}