using System;
using System.Collections.Generic;
using UnityEngine;

namespace IceWall
{
	[Serializable]
	public class UpgradeData
	{
		public UnitData UnitData;
		public float StrengthMultiplier = 1;
		public float CooldownDivisor = 1;
	}
	
	public class UpgradeManager: MonoBehaviour
	{
		public List<UpgradeData> Upgrades;

		public UpgradeData CurrentUpgrade(UnitData unitData)
		{
			UpgradeData upgrade = null;
			
			for (int i = 0; i < Upgrades.Count; i++)
			{
				if (Upgrades[i].UnitData == unitData)
				{
					upgrade = Upgrades[i];
				}
			}

			if (upgrade == null)
			{
				upgrade = new UpgradeData();
			}
			
			return upgrade;
		}
		
		public void UpgradeStrength(UnitData unitData, float strengthIncrease)
		{
			UpgradeData upgrade = CurrentUpgrade(unitData);
			upgrade.StrengthMultiplier += strengthIncrease;
		}
		
		public void UpgradeCooldown(UnitData unitData, float cooldownIncrease)
		{
			UpgradeData upgrade = CurrentUpgrade(unitData);
			upgrade.CooldownDivisor += cooldownIncrease;
		}
	}
}