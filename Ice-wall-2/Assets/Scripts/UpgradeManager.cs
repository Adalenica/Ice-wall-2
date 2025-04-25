using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public int ClickLevel = 1;
    public int Spawn = 0;
    public void Upgrade(string upgradeType)
    {
        switch (upgradeType)
        {
            case "Click":
                ClickLevel++;
                Debug.Log("Click upgraded to " + ClickLevel);
                break;

            case "Spawn":
                Spawn++;
                Debug.Log("Spawn upgraded to " + Spawn);
                break;

            default:
                Debug.LogWarning("Unknown upgrade type: " + upgradeType);
                break;
        }
    }
}
