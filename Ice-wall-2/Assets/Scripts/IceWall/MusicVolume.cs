using UnityEngine;

namespace IceWall
{
	public class MusicVolume: MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;
		

		private void Update()
		{
			if (PlayerPrefs.GetInt("Mute") != 1)
			{
				_audioSource.volume = 1;
			}
			else if (PlayerPrefs.GetInt("Mute") == 1)
			{
				_audioSource.volume = 0;
			}
		}
	}
}