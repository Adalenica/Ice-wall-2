using UnityEngine;
using Random = UnityEngine.Random;

namespace IceWall
{
	public class AerialUnitController: RangeAttackUnitController
	{
		protected override void RandomisePosition()
		{
			Debug.Log($"Current Wall {LevelManager.CurrentWall}");
			float minY = -2f;
			float maxY = 4f;
			float minX = -8f + (LevelManager.CurrentWall * 20);
			float maxX = 5f + (LevelManager.CurrentWall * 20);
			var setPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
			transform.position = setPosition;
		}
	}
}