using UnityEngine;

public class Clicker : MonoBehaviour
{
   public int Click = 1;
   public void Increase (int value)
   {
        Click += value;
   }
}
