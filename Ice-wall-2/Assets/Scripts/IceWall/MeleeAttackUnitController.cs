using System.Collections;
using UnityEngine;

namespace IceWall
{
	public class MeleeAttackUnitController: UnitController
	{
		protected override void StartAttackRoutine()
		{
			StartCoroutine(UnitMeleeAttackRoutine());
		}
		
		protected IEnumerator UnitMeleeAttackRoutine()
		{
			yield return MoveToWall();
			yield return PerformAttack();
			yield return ReturnToOrigin();
			yield return WaitForNextAttack();
			StartCoroutine(UnitMeleeAttackRoutine());
		}
		
		private IEnumerator MoveToWall()
		{
			Debug.Log("MoveToWall");
			var wallPosition = Wall.transform.position;
			var position = transform.position;
			while(position.x < wallPosition.x-1)
			{
				position.x += UnitData.Speed * Time.deltaTime;
				transform.position = position;
				yield return new WaitForEndOfFrame();
			}
			transform.position = new Vector3(wallPosition.x-1, transform.position.y, transform.position.z);
			yield return new WaitForSeconds(1f);
		}
	}
}