using UnityEngine;

[CreateAssetMenu(fileName = "UnitData", menuName="Units/UnitData")]
public class UnitData : ScriptableObject
{
    public int Price;
	public GameObject UnitPrefab;
}
