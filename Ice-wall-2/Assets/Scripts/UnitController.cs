using System;
using UnityEngine;

namespace DefaultNamespace
{
	public class UnitController: MonoBehaviour
	{
		[SerializeField] private UnitData _unitData;	
		
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
				_wall.TakeDamage(_unitData.Strength);
			}
			else
			{
				Debug.Log("No Wall");
			}
		}
	}
}