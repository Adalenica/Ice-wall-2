using UnityEngine;

public class Wall : MonoBehaviour
{

  public int money {get; set;} 
    private void OnMouseDown()
    {
       money = money + 1;
        Debug.Log ("you clicked the wall" + money);    
    }

}
