using UnityEngine;
using UnityEngine.Events;

public class Bank : MonoBehaviour
{
    public int Money = 0;
    public UnityEvent OnChanged;
    public void Deposit(int value)
    {
      Money += value;
      OnChanged.Invoke();
    }
    public void Withdraw(int value)
    {
      if(Money >= value)
      {
        Money -= value;
        OnChanged.Invoke();
      }
    }
}
