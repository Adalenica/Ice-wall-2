using UnityEngine;

public class Wall : MonoBehaviour
{
	[SerializeField] private float _health;
    public Bank Bank;
   
	private void OnMouseDown()
    {
      this.Bank.Deposit(1);
	  _health--;
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
		Debug.Log ("you take damage " + damage);
		this.Bank.Deposit(Mathf.RoundToInt(damage));
		Debug.Log (_health);
	}
}
