using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_End_Lights : MonoBehaviour
{
   
    public GameObject spotlight;
    public GameObject killSwitchSound;
    public GameObject voiceLine;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            spotlight.SetActive(true);
            killSwitchSound.SetActive(true);
            Invoke("PlayVoice", 1f);
            //voiceLine.SetActive(true);
        }
    }

    public void PlayVoice()
    {
        voiceLine.SetActive(true);
    }
}
