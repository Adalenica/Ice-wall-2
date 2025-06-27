using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class OpenShop: MonoBehaviour
	{
		[SerializeField] private GameObject shopWindow;
		[SerializeField] private Button _myButton;
		[SerializeField] private AudioSource _audioSource;

		public void Start()
		{
			shopWindow.SetActive(false);
			_myButton.onClick.AddListener(ButtonClicked);
		}

		public void ButtonClicked()
		{
			if (shopWindow != null)
			{
				_audioSource.Play();
				shopWindow.SetActive(!shopWindow.activeSelf);
			}
		}
	}
}