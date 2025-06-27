using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class MusicButton: MonoBehaviour
	{
		[SerializeField] private Button _myButton;
		[SerializeField] private MusicVolume _musicVolume;

		public void Start()
		{
			_myButton.onClick.AddListener(ButtonClicked);
		}
		
		private void ButtonClicked()
		{
			if (PlayerPrefs.GetInt("Mute") == 1)
			{
				PlayerPrefs.SetInt("Mute", 0);
			}
			else if (PlayerPrefs.GetInt("Mute") != 1)
			{
				PlayerPrefs.SetInt("Mute", 1);
			}
			Debug.Log(PlayerPrefs.GetInt("Mute"));
			_musicVolume.Mute();
		}
	}
}