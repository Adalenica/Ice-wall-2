using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
	public class ShopButtons:MonoBehaviour
	{
		[SerializeField] private Button myButton;
		[SerializeField] private UnitSpawner _unitSpawner;
		[SerializeField] private Bank _bank;
		[SerializeField] private UnitData _unitData;
    
		void Start()
		{
			myButton.onClick.AddListener(ButtonClicked);
		}
    
		void ButtonClicked()
		{
			if (_bank.Withdraw(_unitData.Price))
			{
				Debug.Log("withdraw");
				_unitSpawner.SpawnUnit(_unitData.UnitPrefab);
			}
			else
			{
				Debug.Log("can't withdraw");
			}
		}
	}
}