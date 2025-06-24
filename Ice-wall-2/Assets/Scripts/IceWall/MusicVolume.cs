using UnityEngine;

namespace IceWall
{
	public class MusicVolume: MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;

		private void Start()
		{
			Mute();
		}
		
		public void Mute()
		{
			if (PlayerPrefs.GetInt("Mute") != 1)
			{
				_audioSource.Play();
			}
			else if (PlayerPrefs.GetInt("Mute") == 1)
			{
				_audioSource.Stop();
			}
		}
	}
}