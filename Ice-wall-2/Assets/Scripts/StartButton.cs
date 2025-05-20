using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
	public class StartButton: MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;
		[SerializeField] private Button _myButton;
		[SerializeField] private int _scene;
		
		void Start()
		{
			_myButton.onClick.AddListener(ButtonClicked);
		}
    
		void ButtonClicked()
		{
			_audioSource.Play();
			SceneManager.LoadScene(_scene);
		}
	}
}