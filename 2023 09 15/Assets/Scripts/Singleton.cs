using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
   public static Singleton Instance { get; private set; }


   private void Awake()
    {
       if(Instance == null)
       {
            Instance = this;
            DontDestroyOnLoad(gameObject);
       }
       else
       {
            Destroy(gameObject);
       }
    }

    public int playerscore = 0;

    public void IncreaseScore(int amount)
    {
        playerscore += amount;
    }
}
