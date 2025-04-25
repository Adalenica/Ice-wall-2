using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
	[SerializeField] private UnitSpawner _unitSpawner;
	[SerializeField] private Bank _bank;
    [SerializeField] private UnitData _unitData;
	
    public void OnMouseDown()
    {
		if (_bank.Withdraw(_unitData.Price))
		{
			Debug.Log("withdraw");
			_unitSpawner.SpawnUnit();
		}
		else
		{
			Debug.Log("can't withdraw");
		}
	}
}
