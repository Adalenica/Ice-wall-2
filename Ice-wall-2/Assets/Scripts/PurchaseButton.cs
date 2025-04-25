using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    public Bank Bank;
    [SerializeField] private UnitData _unitData;
    public void OnMouseDown()
    {
        Debug.Log ("withdraw");
        this.Bank.Withdraw(_unitData.Price);
    }
}
