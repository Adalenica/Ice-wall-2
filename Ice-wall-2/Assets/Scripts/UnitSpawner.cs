using DefaultNamespace;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
	[SerializeField] private UpgradeManager _upgradeManager;
	[SerializeField] private LevelManager _levelManager;
	
	[ContextMenu("SpawnUnit")]
	public void SpawnUnit(GameObject unitPrefab)
	{
		var unit = Instantiate(unitPrefab);
		var unitController = unit.GetComponent<UnitController>();
		var aerialUnitController = unit.GetComponent<AerialUnitController>();
		unitController.SetUpgradeManager(_upgradeManager);
		unitController.SetLevelManager(_levelManager);
		aerialUnitController.SetLevelManager(_levelManager);
	}
}
