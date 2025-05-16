using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
	public class LevelManager: MonoBehaviour
	{
		[SerializeField] Wall _wall;

		public void WallDestroyed()
		{
			GameOver();
		}
		
		private void GameOver()
		{
			SceneManager.LoadScene(2);
		}
	}
}