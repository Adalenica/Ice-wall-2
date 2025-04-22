using UnityEngine;

public class Wall : MonoBehaviour
{

    public Bank Bank;
    private void OnMouseDown()
    {
      this.Bank.Deposit(Bank.Clicker);
      Debug.Log ("you clicked the wall" + Bank.Money);    
    }


}
