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
		unitController.SetUpgradeManager(_upgradeManager);
		//unitController.GetLevel(_levelManager.CurrentWall);
	}
}
