using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class MusicButton: MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;
		[SerializeField] private Button _myButton;

		public void Start()
		{
			_myButton.onClick.AddListener(ButtonClicked);
		}
		
		public void ButtonClicked()
		{
			_audioSource.volume = 0;
		}
	}
}