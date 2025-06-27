using UnityEngine;

namespace IceWall
{
	[CreateAssetMenu(fileName = "UnitData", menuName="Units/UnitData")]
	public class UnitData : ScriptableObject
	{
		public int Price;
		public GameObject UnitPrefab;
		public float Strength;
		public float AttackCooldown;
		public int Speed;
		public int ProjectileOffset;
		public Sprite[] CooldownSprites;
		public Sprite[] StrengthSprites;
	}
}
