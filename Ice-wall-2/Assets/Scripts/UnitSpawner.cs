using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
	[ContextMenu("SpawnUnit")]
	public void SpawnUnit(GameObject unitPrefab)
	{
		var unit = Instantiate(unitPrefab);
	}
}
