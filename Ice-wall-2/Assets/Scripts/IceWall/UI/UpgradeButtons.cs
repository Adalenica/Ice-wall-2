using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class UpgradeButtons: MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;
		[SerializeField] private Button myButton;
		[SerializeField] private Bank _bank;
		[SerializeField] private UnitData _unitData;
		[SerializeField] private UpgradeManager _upgradeManager;
		[SerializeField] private int _version;
		
		void Start()
		{
			myButton.onClick.AddListener(ButtonClicked);
		}
    
		void ButtonClicked()
		{
			if (_bank.Withdraw(_unitData.Price))
			{
				if (_version == 1)
				{
					Debug.Log("attack upgraded");
					_audioSource.Play();
					_upgradeManager.UpgradeStrength(_unitData, 1);
				}
				else
				{
					Debug.Log("cooldown upgraded");
					_audioSource.Play();
					_upgradeManager.UpgradeCooldown(_unitData, 1);
				}
			}
			else
			{
				Debug.Log("can't withdraw");
			}
		}
	}
}