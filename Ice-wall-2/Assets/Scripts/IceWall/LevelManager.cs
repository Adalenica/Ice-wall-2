using IceWall.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace IceWall
{
	public class LevelManager: MonoBehaviour
	{
		[SerializeField] Wall _wall;
		[SerializeField] GameObject _wall2;
		[SerializeField] GameObject _wall3;
		[SerializeField] GameObject _wall4;
		[SerializeField] HealthCounter _healthCounter;
		[SerializeField] HealthBar _healthBar;
		[SerializeField] CameraController _cameraController;
		public int CurrentWall = 0;
		private int _numberLevels = 4;
		
		public void Start()
		{
			_wall2.SetActive(false);
			_wall3.SetActive(false);
			_wall4.SetActive(false);
			_healthCounter.SetUp();
			_healthBar.SetUp();
			
		}
		
		public void WallDestroyed()
		{
			CurrentWall ++;
			if (CurrentWall == 1f)
			{
				StartLevel2();
			}

			if (CurrentWall == 2f)
			{
				StartLevel3();
			}
			
			if (CurrentWall == 3f)
			{
				StartLevel4();
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
			_wall2.SetActive(true);
			NewLevel();
		}

		private void StartLevel3()
		{
			_wall3.SetActive(true);
			NewLevel();
		}
		
		private void StartLevel4()
		{
			_wall4.SetActive(true);
			NewLevel();
		}

		private void NewLevel()
		{
			UnitManager.Instance.DestroyAllUnits();
			_healthCounter.SetUp();
			_healthBar.SetUp();
			_cameraController.CameraTransition();
		}
	}
}