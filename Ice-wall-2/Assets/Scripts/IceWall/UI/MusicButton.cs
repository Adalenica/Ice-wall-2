using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class MusicButton: MonoBehaviour
	{
		[SerializeField] private GameObject _audioSource;
		[SerializeField] private Button _myButton;

		public void Start()
		{
			_myButton.onClick.AddListener(ButtonClicked);
		}
		
		public void ButtonClicked()
		{
			if (_audioSource != null)
			{
				_audioSource.SetActive(!_audioSource.activeSelf);
			}
		}
	}
}