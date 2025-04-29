using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
	[ContextMenu("SpawnUnit")]
	public void SpawnUnit(GameObject unitPrefab)
	{
		float minX = -7f;
		float maxX = 5f;

		Vector2 spawnPosition = new Vector2(Random.Range(minX, maxX), -4f);
		
		var unit = Instantiate(unitPrefab, spawnPosition, Quaternion.identity);
	}
}
