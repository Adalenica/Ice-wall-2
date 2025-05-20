using DefaultNamespace;
using UnityEngine;
using UnityEngine.Events;

public class Wall : MonoBehaviour
{
	[SerializeField] public float Health;
	[SerializeField] private AudioSource _audioSource;
	[SerializeField] private LevelManager _levelManager;
	public UnityEvent OnChanged;

    public Bank Bank;
   
	private void OnMouseDown()
    {
      this.Bank.Deposit(1);
	  Health--;
	  OnChanged.Invoke();
	  _audioSource.Play();
	  Debug.Log (Health);
    }

	private void Update()
	{
		if (Health <= 0)
		{
			Destroy(gameObject);
			_levelManager.WallDestroyed();
		}
	}

	public void TakeDamage(float damage)
	{
		Health -= damage;
		OnChanged.Invoke();
		_audioSource.Play();
		Debug.Log ("you take damage " + damage);
		this.Bank.Deposit(Mathf.RoundToInt(damage));
		Debug.Log (Health);
	}
}
