using UnityEngine;
using TMPro;

public class MoneyCounter : MonoBehaviour
{
   public Bank Bank;
   public TextMeshProUGUI label;
    public void Awake()
    {
        label.text = Bank.Money.ToString();
        Bank.OnChanged.AddListener(UpdateLabel);
    }
    public void UpdateLabel()
    {
        label.text = Bank.Money.ToString();
    }
    public void OnDestroy()
    {
        Bank.OnChanged.RemoveListener(UpdateLabel);
    }
}
