using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
	public class UpgradeButtons: MonoBehaviour
	{
		[SerializeField] private Button myButton;
		[SerializeField] private Bank _bank;
		[SerializeField] private UnitData _unitData;
		[SerializeField] private UpgradeManager _upgradeManager;
		
		void Start()
		{
			myButton.onClick.AddListener(ButtonClicked);
		}
    
		void ButtonClicked()
		{
			if (_bank.Withdraw(_unitData.Price))
			{
				Debug.Log("withdraw");
			}
			else
			{
				Debug.Log("can't withdraw");
			}
		}
	}
}