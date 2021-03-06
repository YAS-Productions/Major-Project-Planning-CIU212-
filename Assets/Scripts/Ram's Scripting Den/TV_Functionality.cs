using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV_Functionality : MonoBehaviour
{
    public GameObject changeChannelCanvas;
    public VideoPlayer videoPlayer;

    public VideoClip[] channels;
    [SerializeField]
    private int currentChannel = 0;

    public GameObject puzzleComplete;

    //public VideoClip channel_1;
    //public VideoClip channel_2;
    private bool playJingle = false;

    private void Start()
    {
        
    }


    private void Update()
    {
        videoPlayer.clip = channels[currentChannel];

        if (currentChannel == 5)
        {
            puzzleComplete.SetActive(true);
            if(playJingle == false)
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/Feedback/Success Jingle");
                playJingle = true;
            }
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            changeChannelCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            changeChannelCanvas.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ChangeChannelUP();
            }
        }
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ChangeChannelDOWN();
            }
        }
    }

    void ChangeChannelUP()
    {


        currentChannel += 1;

        Debug.Log(currentChannel);

        if (currentChannel >= channels.Length)
        {
            currentChannel = 0;
        }


        //videoPlayer.clip = channels[0];
    }
    void ChangeChannelDOWN()
    {


        currentChannel -= 1;

       

        if (currentChannel <= 0)
        {
            currentChannel = 0;
        }


        //videoPlayer.clip = channels[0];
    }
}