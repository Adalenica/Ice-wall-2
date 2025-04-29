using UnityEngine;

namespace DefaultNamespace
{
	public class UnitController: MonoBehaviour
	{
		[ContextMenu("Attack")]
		public void Attack()
		{
			Debug.Log("Attack");
		}
	}
}