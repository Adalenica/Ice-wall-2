using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
	public class AerialUnitController: MonoBehaviour
	{
		private void Start()
		{
			RandomisePosition();
		}
		private void RandomisePosition()
		{
			float minX = -7f;
			float maxX = 5f;
			float minY = -2f;
			float maxY = 4f;

			var setPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
			transform.position = setPosition;
		}
		
	}
}