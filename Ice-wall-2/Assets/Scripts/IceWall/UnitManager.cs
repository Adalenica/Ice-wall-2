using System.Collections.Generic;
using UnityEngine;

namespace IceWall
{
	public class UnitManager : MonoBehaviour
	{
		public static UnitManager Instance;
    
		private List<GameObject> allUnits = new List<GameObject>();

		private void Awake()
		{
			if (Instance == null) Instance = this;
			else Destroy(gameObject);
		}

		public void RegisterUnit(GameObject unit)
		{
			allUnits.Add(unit);
		}

		public void UnregisterUnit(GameObject unit)
		{
			allUnits.Remove(unit);
		}

		public void DestroyAllUnits()
		{
			foreach (GameObject unit in allUnits)
			{
				Destroy(unit);
			}
			allUnits.Clear();
		}
	}
}