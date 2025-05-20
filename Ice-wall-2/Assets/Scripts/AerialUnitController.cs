using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
	public class AerialUnitController: MonoBehaviour
	{
		private LevelManager _levelManager;
		
		private void Start()
		{
			RandomisePosition();
		}

		public void SetLevelManager(LevelManager levelManager)
		{
			_levelManager = levelManager;
		}

		private void RandomisePosition()
		{
			if (_levelManager.CurrentWall == 1)
			{
				float minY = -2f;
				float maxY = 4f;
				float minX = 18f;
				float maxX = 25f;
				var setPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
				transform.position = setPosition;
			}
			else
			{
				float minY = -2f;
				float maxY = 4f;
				float minX = -7f;
				float maxX = 5f;
				var setPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
				transform.position = setPosition;
			}
		}
	}
}