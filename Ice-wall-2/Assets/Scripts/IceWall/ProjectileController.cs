using System.Collections;
using UnityEngine;

namespace IceWall
{
	public class ProjectileController: MonoBehaviour
	{
		[SerializeField] private ProjectileData _projectileData;
		private Wall _wall;
		private UnitController _unitController;
		private RangeAttackUnitController _rangeAttackUnitController;
		private AerialUnitController _aerialUnitController;
		private UpgradeData _upgrade;

		public void SetTarget(Wall wall)
		{
			_wall = wall;
			StartCoroutine(ProjectileAttackRoutine());
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
			var damage = _projectileData.Damage * _upgrade.StrengthMultiplier;
			_wall.TakeDamage(damage);
			yield return null;
		}

		public void SetUpgrade(UpgradeData upgrade)
		{
			_upgrade = upgrade;
		}
	}
}