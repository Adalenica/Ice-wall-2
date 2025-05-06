using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
	public class RangeAttackUnitController: UnitController
	{
		[SerializeField] private ProjectileData ProjectileData;
		private ProjectileController _projectileController;
		protected override void StartAttackRoutine()
		{
			StartCoroutine(UnitRangedAttackRoutine());
		}

		private IEnumerator UnitRangedAttackRoutine()
		{
			yield return FireProjectile();
			yield return WeaponCooldown();
			StartCoroutine(UnitRangedAttackRoutine());
		}

		private IEnumerator WeaponCooldown()
		{
			yield return new WaitForSeconds(UnitData.AttackCooldown);
		}

		private IEnumerator FireProjectile()
		{
			Vector3 offset = transform.up * 1f;
			var bullet = Instantiate(ProjectileData.ProjectilePrefab, transform.position + offset, Quaternion.identity);
			var projectileController = bullet.GetComponent<ProjectileController>();
			projectileController.SetTarget(Wall);
			yield return new WaitForSeconds(1f);
		}
	}
}