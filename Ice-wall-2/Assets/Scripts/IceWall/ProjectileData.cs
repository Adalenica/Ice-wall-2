using UnityEngine;

namespace IceWall
{
	[CreateAssetMenu(fileName = "ProjectileData", menuName="Projectiles/ProjectileData")]
	public class ProjectileData : ScriptableObject
	{
		public GameObject ProjectilePrefab;
		public int Speed;
		public int Damage;
	}
}
