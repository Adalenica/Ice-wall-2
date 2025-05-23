using UnityEngine;

namespace DefaultNamespace
{
	public class CameraController: MonoBehaviour
	{
		[SerializeField] private float _moveDistance = 5f;
		[SerializeField] private float _moveSpeed = 5f;
		
		private bool isMoving = false;
		private Vector3 targetPosition;
		
		public void CameraTransition()
		{
			StartCoroutine(MoveCameraSmoothly());
		}
		
		private System.Collections.IEnumerator MoveCameraSmoothly()
		{
			isMoving = true;
			targetPosition = transform.position + new Vector3(_moveDistance, 0f, 0f);

			while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
			{
				transform.position = Vector3.MoveTowards(transform.position, targetPosition, _moveSpeed * Time.deltaTime);
				yield return null;
			}

			transform.position = targetPosition;
			isMoving = false;
		}
	}
}