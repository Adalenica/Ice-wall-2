using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName="Bullets/BulletData")]
public class BulletData : ScriptableObject
{
	public GameObject BulletPrefab;
	public int Speed;
	public int Damage;
}
