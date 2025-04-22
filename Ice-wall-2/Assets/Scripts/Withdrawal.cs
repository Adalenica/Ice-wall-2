using UnityEngine;

public class Withdrawal : MonoBehaviour
{
    public Bank Bank;
    [SerializeField]private int Price;
    private void OnMouseDown()
    {
        if (Bank.Money >= Price )
        {  
            this.Bank.Withdraw(-Price);
            Bank.Clicker ++;
            Price ++;
        }
    }
}
