using UnityEngine;

public class Wall : MonoBehaviour
{
	[SerializeField] private int _health;
    public Bank Bank;
   
	private void OnMouseDown()
    {
      this.Bank.Deposit(1);
	  _health--;
	  Debug.Log ("you clicked the wall" + Bank.Money); 
	  Debug.Log (_health);
    }

	private void Update()
	{
		if (_health <= 0)
		{
			Destroy(gameObject);
		}
	}

	public void TakeDamage(int damage)
	{
		_health -= damage;
		Debug.Log ("you take damage " + damage);
		this.Bank.Deposit(damage);
		Debug.Log (_health);
	}
}
