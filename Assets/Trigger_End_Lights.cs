using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_End_Lights : MonoBehaviour
{
   
    public GameObject spotlight;
    public GameObject killSwitchSound;
    public GameObject voiceLine;

    public float voiceLineDuration;

   
    [SerializeField]
    private GameObject player;

    private bool canWalk = true;

    private void Start()
    {
       
    }

    private void Update()
    {
       
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            spotlight.SetActive(true);
            killSwitchSound.SetActive(true);
            Invoke("PlayVoiceLine", 1f);
            if(canWalk == true)
            {
                player.GetComponent<Rigidbody>().isKinematic = true;
                canWalk = false;
            }
            

            Invoke("EnableMovement", voiceLineDuration);
        }
    }

    public void PlayVoiceLine()
    {
        voiceLine.SetActive(true);
    }

    public void EnableMovement()
    {
        player.GetComponent<Rigidbody>().isKinematic = false;

    }
}
