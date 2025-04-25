using UnityEngine;

public class Wall : MonoBehaviour
{

    public Bank Bank;
    public Clicker Clicker;
    private void OnMouseDown()
    {
      this.Bank.Deposit(Clicker.Click);
      Debug.Log ("you clicked the wall" + Bank.Money);    
    }


}
