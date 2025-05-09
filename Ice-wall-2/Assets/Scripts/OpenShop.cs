using UnityEngine;

namespace DefaultNamespace
{
	public class OpenShop: MonoBehaviour
	{
		[SerializeField] private GameObject shopWindow;

		public void OnMouseDown()
		{
			if (shopWindow != null)
			{
				shopWindow.SetActive(!shopWindow.activeSelf);
			}
		}
	}
}