using System.Collections;
using UnityEditor.U2D;
using UnityEngine;

namespace IceWall
{
	public class RangeAttackUnitController: UnitController
	{
		[SerializeField] private ProjectileData ProjectileData;
		[SerializeField] private SpriteRenderer _blastSpriteRenderer;
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
			Blast();
			Vector3 offset = transform.up * UnitData.ProjectileOffset;
			var upgrade = UpgradeManager.CurrentUpgrade(UnitData);
			var bullet = Instantiate(ProjectileData.ProjectilePrefab, transform.position + offset, Quaternion.identity);
			var projectileController = bullet.GetComponent<ProjectileController>();
			projectileController.SetTarget(Wall);
			projectileController.SetUpgrade(upgrade);
			yield return new WaitForSeconds(1f);
		}

		private void Blast()
		{
			_blastSpriteRenderer.enabled = true;	
			StartCoroutine(DisableBlastAfterDelay());
		}
		
		IEnumerator DisableBlastAfterDelay()
		{
			yield return new WaitForSeconds(1f);
			_blastSpriteRenderer.enabled = false;
		}
	}
}