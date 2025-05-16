using UnityEngine;

public class Wall : MonoBehaviour
{
	[SerializeField] private float _health;
	[SerializeField] private AudioSource _audioSource;

    public Bank Bank;
   
	private void OnMouseDown()
    {
      this.Bank.Deposit(1);
	  _health--;
	  _audioSource.Play();
	  Debug.Log (_health);
    }

	private void Update()
	{
		if (_health <= 0)
		{
			Destroy(gameObject);
		}
	}

	public void TakeDamage(float damage)
	{
		_health -= damage;
		_audioSource.Play();
		Debug.Log ("you take damage " + damage);
		this.Bank.Deposit(Mathf.RoundToInt(damage));
		Debug.Log (_health);
	}
}
