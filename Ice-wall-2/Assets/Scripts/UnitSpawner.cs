using UnityEngine;
using UnityEngine.Events;

public class UnitSpawner : MonoBehaviour
{
	[SerializeField] private GameObject _unitPrefab;
	
	
	[ContextMenu("SpawnUnit")]
	public void SpawnUnit()
	{
		var unit = Instantiate(_unitPrefab);
	}
}
