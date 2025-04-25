using UnityEngine;

public class Withdrawal : MonoBehaviour
{
    public Bank Bank;
    public Clicker Clicker;
    public Spawner Spawner;
    [SerializeField]private int Price;
   // private void OnMouseDown()
   // {
   //     if (Bank.Money >= Price )
   //     {  
   //         this.Bank.Withdraw(-Price);
   //         this.Clicker.Increase(1);
   //         this.Spawner.Increase(1);
   //         Price ++;
   //     }
   // }

    private void OnMouseDown(string UpgradeType)
    {
        switch(UpgradeType)
        {
            case "Click":
                if (Bank.Money >= Price)
                {
                    this.Bank.Withdraw(-Price);
                    Clicker.Click++;
                    Price++;
                    break;
                }
            case "Spawn":
                if (Bank.Money >= Price)
                {
                    this.Bank.Withdraw(-Price);
                    Spawner.Spawn++;
                    Price++;
                    break;
                }
            default:
                Debug.Log("Uknown upgrade type");
                break;
        }
    }

}