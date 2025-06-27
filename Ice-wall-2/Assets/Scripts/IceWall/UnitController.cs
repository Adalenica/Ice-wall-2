using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace IceWall
{
	public class UnitController: MonoBehaviour
	{
		[SerializeField] protected UnitData UnitData;
		[SerializeField] protected SpriteRenderer CooldownSprite;
		[SerializeField] protected SpriteRenderer StrengthSprite;
		
		protected Wall Wall;
		public Vector2 SpawnPosition;
		protected UpgradeManager UpgradeManager;
		protected LevelManager LevelManager;
		protected int SpriteStrengthIndex;
		protected int SpriteCooldownIndex;

		[ContextMenu("Attack")]
		public void Attack()
		{
			Debug.Log("Attack");
		}
		
		protected virtual void Start()
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

		protected virtual void Update()
		{
			SetUnitSprite();
		}

		protected virtual void SetUnitSprite()
		{
			var upgrade = UpgradeManager.CurrentUpgrade(UnitData);
			
			if(SpriteCooldownIndex != upgrade.SpriteCooldownIndex)
			{
				SpriteCooldownIndex = upgrade.SpriteCooldownIndex;
				UpdateCooldownSprite();
			}	
			
			if(SpriteStrengthIndex != upgrade.SpriteStrengthIndex)
			{
				SpriteStrengthIndex = upgrade.SpriteStrengthIndex;
				UpdateStrengthSprite();
			}	
			
		}

		protected virtual void UpdateStrengthSprite()
		{
			if (SpriteStrengthIndex >= UnitData.StrengthSprites.Length) return;
			if (!StrengthSprite) return;
			
			StrengthSprite.sprite = UnitData.StrengthSprites[SpriteStrengthIndex];
		}

		protected virtual void UpdateCooldownSprite()
		{
			if (SpriteCooldownIndex >= UnitData.CooldownSprites.Length) return;
			if (!CooldownSprite) return;
			
			CooldownSprite.sprite = UnitData.CooldownSprites[SpriteCooldownIndex];
		}

		protected virtual void RandomisePosition()
		{
			float minX = -8f + (LevelManager.CurrentWall * 20);
			float maxX = 5f + (LevelManager.CurrentWall * 20);
			SpawnPosition = new Vector2(Random.Range(minX, maxX), -4f);
			transform.position = SpawnPosition;
			
			Debug.Log($"SpawnPosition {SpawnPosition.x}, {SpawnPosition.y}, {minX}, {maxX}");
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

		public void SetLevelManager(LevelManager levelManager)
		{
			LevelManager = levelManager;
		}
		
		private void OnDestroy()
		{
			UnitManager.Instance?.UnregisterUnit(gameObject);
		}
	}
}