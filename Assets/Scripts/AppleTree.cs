using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public int state = 0;

    public static AppleTree Instance;

    

    void Start()
    {
        Instance = this;
        Invoke("Groving", 5);
    }

 

    void Groving()
    {
        state = 1;

        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && state==1) 
        {
            state = 2;
            Invoke("Harvesting", 3);
            Invoke("Groving", 15);
            
        }
    }

    void Harvesting()
    {
        state = 0;
    }
}
