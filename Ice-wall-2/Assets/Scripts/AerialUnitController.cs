using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
	public class AerialUnitController: RangeAttackUnitController
	{
		protected override void RandomisePosition()
		{
			if (Mathf.Approximately(LevelManager.CurrentWall, 1f))
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