using DefaultNamespace;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
	[SerializeField] private UpgradeManager _upgradeManager;
	
	[ContextMenu("SpawnUnit")]
	public void SpawnUnit(GameObject unitPrefab)
	{
		var unit = Instantiate(unitPrefab);
		var unitController = unit.GetComponent<UnitController>();
		unitController.SetUpgradeManager(_upgradeManager);
	}
}
