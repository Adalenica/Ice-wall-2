using UnityEngine;

namespace IceWall.UI
{
	public class OpenShop: MonoBehaviour
	{
		[SerializeField] private GameObject shopWindow;

		public void Start()
		{
			shopWindow.SetActive(false);
		}

		public void OnMouseDown()
		{
			if (shopWindow != null)
			{
				shopWindow.SetActive(!shopWindow.activeSelf);
			}
		}
	}
}