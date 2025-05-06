using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
	public class RangeAttackUnitController: UnitController
	{
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
			Debug.Log("Fire Projectile");
			yield return new WaitForSeconds(1f);
		}
	}
}