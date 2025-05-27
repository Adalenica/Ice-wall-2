using TMPro;

namespace IceWall.UI
{
	public class ShopLabels: PurchaseButton
	{
		public TextMeshProUGUI _label;
		
		public void Awake()
		{
			_label.text = _unitData.name + "  " + _unitData.Price;
		}
	}
}