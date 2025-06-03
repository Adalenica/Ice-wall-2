using UnityEngine;
using TMPro;

namespace IceWall.UI
{
	public class UpgradeButtonText: MonoBehaviour
	{
		public TextMeshProUGUI _label;
		private int _upgradeAmount;

		private void Awake()
		{
			_upgradeAmount = 1;
			_label.text = "x" + _upgradeAmount;
		}

		public void UpdateLabel()
		{
			_upgradeAmount ++;
			_label.text = "x" + _upgradeAmount;
		}
		
	}
}