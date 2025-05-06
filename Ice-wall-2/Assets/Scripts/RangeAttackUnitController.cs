using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
	public class RangeAttackUnitController: UnitController
	{
		[SerializeField] private ProjectileData ProjectileData;
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
			Debug.Log("Weapon Cooldown");
			yield return new WaitForSeconds(UnitData.AttackCooldown);
		}

		private IEnumerator FireProjectile()
		{
			var bullet = Instantiate(ProjectileData.ProjectilePrefab);
			Debug.Log("Fire Projectile");
			yield return new WaitForSeconds(1f);
		}
	}
}