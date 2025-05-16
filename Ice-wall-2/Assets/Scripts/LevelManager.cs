using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
	public class LevelManager: MonoBehaviour
	{
		[SerializeField] Wall _wall;
		private int _currentWall = 0;
		
		public void WallDestroyed()
		{
			_currentWall++;
			if (_currentWall >= 1)
			{
				GameOver();
			}
		}
		private void GameOver()
		{
			SceneManager.LoadScene(2);
		}
	}
}