using System.Collections;
using UnityEditor.Scripting;
using UnityEngine;

namespace DefaultNamespace
{
	public class ProjectileController: MonoBehaviour
	{
		[SerializeField] private ProjectileData _projectileData;
		private Wall _wall;
		private UnitController _spawnPosition;

		private void Start()
		{
			SetUp();
			StartCoroutine(ProjectileAttackRoutine());
		}

		private void SetUp()
		{
			_wall = FindFirstObjectByType<Wall>();
			//SpawnPosition();
		}

		private void SpawnPosition()
		{
			
		}
	

		private IEnumerator ProjectileAttackRoutine()
		{
			yield return MoveToWall();
			yield return AttackWall();
			Destroy(gameObject);
		}

		private IEnumerator MoveToWall()
		{
			Debug.Log("MoveToWall");
			var wallPosition = _wall.transform.position;
			var position = transform.position;
			while (position.x < wallPosition.x - 1)
			{
				position.x += _projectileData.Speed * Time.deltaTime;
				transform.position = position;
				yield return new WaitForEndOfFrame();
			}
		}

		private IEnumerator AttackWall()
		{
			Debug.Log("attacking wall");
			_wall.TakeDamage(_projectileData.Damage);
			yield return new WaitForSeconds(1f);
		}
	}
}