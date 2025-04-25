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

}
