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
			var upgrade = UpgradeManager.CurrentUpgrade(UnitData);
			var cooldown = UnitData.AttackCooldown;
			cooldown /= upgrade.CooldownDivisor;
			yield return new WaitForSeconds(cooldown);
		}

		private IEnumerator FireProjectile()
		{
			Vector3 offset = transform.up * 1f;
			var upgrade = UpgradeManager.CurrentUpgrade(UnitData);
			var bullet = Instantiate(ProjectileData.ProjectilePrefab, transform.position + offset, Quaternion.identity);
			var projectileController = bullet.GetComponent<ProjectileController>();
			projectileController.SetTarget(Wall);
			projectileController.SetUpgrade(upgrade);
			yield return new WaitForSeconds(1f);
		}
	}
}