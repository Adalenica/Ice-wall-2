using System;
using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
	public class UnitController: MonoBehaviour
	{
		[SerializeField] private UnitData _unitData;	
		
		private Wall _wall;
		
		[ContextMenu("Attack")]
		public void Attack()
		{
			Debug.Log("Attack");
		}
		
		public void Start()
		{
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
			yield return new WaitForSeconds(1f);
		}

		private IEnumerator ReturnToOrigin()
		{
			Debug.Log("Return to origin");
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
			yield return new WaitForSeconds(1f);
		}
	}
}