using UnityEngine;
using UnityEngine.Events;

public class Bank : MonoBehaviour
{
    public int Money = 0;
    public UnityEvent OnChanged;
    public int Clicker = 1;
    public void Deposit(int value)
    {
      Money += value;
      OnChanged.Invoke();
    }
    public void Withdraw(int value)
    {
      Money += value;
      OnChanged.Invoke();
    }
}
