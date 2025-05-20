using UnityEngine;
using DefaultNamespace;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
	public class LevelManager: MonoBehaviour
	{
		[SerializeField] Wall _wall;
		private float _currentWall = 0;
		private int _numberLevels = 2;

		public void Start()
		{
			
		}
		
		public void WallDestroyed()
		{
			_currentWall ++;
			if (_currentWall == 1)
			{
				StartLevel2();
			}

			if (_currentWall >= _numberLevels)
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
			UnitManager.Instance.DestroyAllUnits();
		}
	}
}