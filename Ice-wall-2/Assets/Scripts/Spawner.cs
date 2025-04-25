using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
   public int Spawn = 1;
   public void Increase (int value)
   {
        Spawn += value;
   }
}
