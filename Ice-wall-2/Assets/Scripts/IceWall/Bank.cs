using UnityEngine;
using UnityEngine.Events;

namespace IceWall
{
	public class Bank : MonoBehaviour
	{
		[SerializeField] private AudioSource _audioSource;
		public int Money = 0;
		public UnityEvent OnChanged;
    
		public void Deposit(int value)
		{
			Money += value;
			OnChanged.Invoke();
		}
		public bool Withdraw(int value)
		{
			if(Money >= value)
			{
				Money -= value;
				_audioSource.Play();
				OnChanged.Invoke();
				return true;
			} 
	  
			return false;
		}
	}
}
