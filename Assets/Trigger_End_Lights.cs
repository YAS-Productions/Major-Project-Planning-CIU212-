using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_End_Lights : MonoBehaviour
{
   
    public GameObject spotlight;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            spotlight.SetActive(true);

        }
    }
}
