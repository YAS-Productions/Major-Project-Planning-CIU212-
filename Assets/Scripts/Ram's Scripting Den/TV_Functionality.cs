using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV_Functionality : MonoBehaviour
{
    public GameObject changeChannelCanvas;
    public VideoPlayer videoPlayer;

    public VideoClip[] channels;
    private int currentChannel = 0;

    public GameObject puzzleComplete;

    //public VideoClip channel_1;
    //public VideoClip channel_2;

    private void Update()
    {
        if(currentChannel == 4)
        {
            puzzleComplete.SetActive(true);
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
                ChangeChannel();
            }
        }
    }

    void ChangeChannel()
    {
        videoPlayer.clip = channels[currentChannel++];
        //currentChannel++;

        Debug.Log(currentChannel);

        if(currentChannel >= channels.Length)
        {
            currentChannel = 0;
        }

        //videoPlayer.clip = channels[0];
    }
}