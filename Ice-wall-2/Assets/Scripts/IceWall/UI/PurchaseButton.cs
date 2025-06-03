using UnityEngine;

namespace IceWall.UI
{
	public class PurchaseButton : MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;
		[SerializeField] private UnitSpawner _unitSpawner;
		[SerializeField] private Bank _bank;
		[SerializeField] protected UnitData _unitData;
	
		public void OnMouseDown()
		{
			if (_bank.Withdraw(_unitData.Price))
			{
				_audioSource.Play();
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
