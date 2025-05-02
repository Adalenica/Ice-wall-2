using System;
using UnityEngine;

namespace DefaultNamespace
{
	public class UnitController: MonoBehaviour
	{
		private Wall _wall;
		[ContextMenu("Attack")]
		public void Attack()
		{
			Debug.Log("Attack");
		}
		public void Start()
		{
			_wall = FindFirstObjectByType<Wall>();
			if (_wall != null)
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