using System;
using UnityEngine;

namespace DefaultNamespace
{
	public class UnitController: MonoBehaviour
	{
		private Wall wall;
		[ContextMenu("Attack")]
		public void Attack()
		{
			Debug.Log("Attack");
		}
		public void Start()
		{
			wall = FindObjectOfType<Wall>();
			if (wall != null)
			{
				Debug.Log("Found Wall");
			}
			else
			{
				Debug.Log("No Wall");
			}
		}
	}
}