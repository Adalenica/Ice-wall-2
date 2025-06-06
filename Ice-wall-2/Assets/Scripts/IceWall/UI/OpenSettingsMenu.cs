using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class OpenSettingsMenu: MonoBehaviour
	{
		[SerializeField] private GameObject _settingsMenu;
		[SerializeField] private Button _myButton;

		public void Start()
		{
			_settingsMenu.SetActive(false);
			_myButton.onClick.AddListener(ButtonClicked);
		}

		private void ButtonClicked()
		{
			if (_settingsMenu != null)
			{
				_settingsMenu.SetActive(!_settingsMenu.activeSelf);
			}
		}
	}
}