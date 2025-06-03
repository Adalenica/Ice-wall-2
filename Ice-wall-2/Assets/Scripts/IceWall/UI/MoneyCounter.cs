using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace IceWall.UI
{
	public class MoneyCounter : MonoBehaviour
	{
		public Bank Bank;
		public TextMeshProUGUI Label;
		
		public void Awake()
		{
			UpdateLabel();
			Bank.OnChanged.AddListener(UpdateLabel);
		}
		
		public void UpdateLabel()
		{
			Label.text = $"£{Bank.Money.ToString()}";
		}
		
		public void OnDestroy()
		{
			Bank.OnChanged.RemoveListener(UpdateLabel);
		}
	}
}
