using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class ShopButtons:MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;
		[SerializeField] private Button _myButton;
		[SerializeField] private UnitSpawner _unitSpawner;
		[SerializeField] private Bank _bank;
		[SerializeField] protected UnitData _unitData;
    
		void Start()
		{
			_myButton.onClick.AddListener(ButtonClicked);
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
				_audioSource.Play();
			}
		}
	}
}