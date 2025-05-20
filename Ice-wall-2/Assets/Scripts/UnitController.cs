using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
	public class UnitController: MonoBehaviour
	{
		[SerializeField] protected UnitData UnitData;
		
		protected Wall Wall;
		public Vector2 SpawnPosition;
		protected UpgradeManager UpgradeManager;

		[ContextMenu("Attack")]
		public void Attack()
		{
			Debug.Log("Attack");
		}
		
		public void Start()
		{
			Setup();
			StartAttackRoutine();
			UnitManager.Instance.RegisterUnit(gameObject);
		}

		protected virtual void StartAttackRoutine()
		{
			
		}

		private void Setup()
		{
			RandomisePosition();
			Wall = FindFirstObjectByType<Wall>();
		}
		
		private void RandomisePosition()
		{
			float minX = -7f;
			float maxX = 5f;

			 SpawnPosition = new Vector2(Random.Range(minX, maxX), -4f);
			transform.position = SpawnPosition;
		}

		

		protected IEnumerator WaitForNextAttack()
		{
			var upgrade = UpgradeManager.CurrentUpgrade(UnitData);
			var cooldown = UnitData.AttackCooldown;
			cooldown /= upgrade.CooldownDivisor;
			yield return new WaitForSeconds(cooldown);
		}

		protected IEnumerator ReturnToOrigin()
		{
			Debug.Log("Return to origin");
			var position = transform.position;
			while (position.x > SpawnPosition.x)
			{
				position.x -= UnitData.Speed * Time.deltaTime;
				transform.position = position;
				yield return new WaitForEndOfFrame();
			}
			yield return new WaitForSeconds(1f);
		}

		protected IEnumerator PerformAttack()
		{
			var upgrade = UpgradeManager.CurrentUpgrade(UnitData);
			var strength = UnitData.Strength;
			strength *= upgrade.StrengthMultiplier;
			Wall.TakeDamage(strength);
			yield return new WaitForSeconds(1f);
		}
		
		public void SetUpgradeManager(UpgradeManager upgradeManager)
		{
			UpgradeManager = upgradeManager;
		}

		private void OnDestroy()
		{
			UnitManager.Instance?.UnregisterUnit(gameObject);
		}
	}
}