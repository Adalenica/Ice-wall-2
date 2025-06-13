using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class MusicSlider: MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;
		[SerializeField] private Slider _musicSlider;

		private void Start()
		{
			_musicSlider.value = _audioSource.volume;
			_musicSlider.onValueChanged.AddListener(SetVolume);
		}
		
		public void SetVolume(float volume)
		{
			_audioSource.volume = volume;
			PlayerPrefs.SetFloat("MasterVolume", volume);
		}
		
	}
}