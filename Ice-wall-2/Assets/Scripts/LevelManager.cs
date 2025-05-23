using UnityEngine;
using DefaultNamespace;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
	public class LevelManager: MonoBehaviour
	{
		[SerializeField] Wall _wall;
		[SerializeField] GameObject wall2;
		[SerializeField] HealthCounter _healthCounter;
		[SerializeField] HealthSlider _healthSlider;
		[SerializeField] CameraController _cameraController;
		public float CurrentWall = 0;
		private int _numberLevels = 2;
		
		public void Start()
		{
			wall2.SetActive(false);
		}
		
		public void WallDestroyed()
		{
			CurrentWall ++;
			if (CurrentWall == 1f)
			{
				StartLevel2();
			}

			if (CurrentWall >= _numberLevels)
			{
				GameOver();
			}
		}
		private void GameOver()
		{
			SceneManager.LoadScene(2);
		}

		private void StartLevel2()
		{
			NewLevel();
			wall2.SetActive(true);
		}

		private void NewLevel()
		{
			UnitManager.Instance.DestroyAllUnits();
			_healthCounter.Awake();
			_healthSlider.Awake();
			_cameraController.CameraTransition();
		}
	}
}