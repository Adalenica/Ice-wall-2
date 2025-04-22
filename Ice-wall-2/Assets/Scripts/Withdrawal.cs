using UnityEngine;

public class Withdrawal : MonoBehaviour
{
    public Bank Bank;
    private void OnMouseDown()
    {
        this.Bank.Withdraw(-1);
    }
}
