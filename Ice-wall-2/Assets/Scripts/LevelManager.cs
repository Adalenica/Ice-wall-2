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
		[SerializeField] CameraController _cameraController;
		public float CurrentWall = 0;
		private int _numberLevels = 2;
		public Camera camera1;
		public Camera camera2;


		public void Start()
		{
			wall2.SetActive(false);
		}
		
		public void WallDestroyed()
		{
			CurrentWall ++;
			if (CurrentWall == 1)
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
			//SwitchCamera();
		}

		private void NewLevel()
		{
			UnitManager.Instance.DestroyAllUnits();
			_healthCounter.Awake();
			_cameraController.CameraTransition();
		}

		void SwitchCamera()
		{
			camera1.enabled = !camera1.enabled;
			camera2.enabled = !camera2.enabled;
		}
	}
}