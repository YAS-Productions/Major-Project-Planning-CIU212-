using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV_Functionality : MonoBehaviour
{
    public GameObject changeChannelCanvas;
    public VideoPlayer videoPlayer;
    public VideoClip channel_1;
    public VideoClip channel_2;

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
                if (videoPlayer.clip = channel_1)
                {
                    videoPlayer.clip = channel_2;
                }
                else if (videoPlayer.clip = channel_2)
                {
                    videoPlayer.clip = channel_1;
                }
            }

        }
    }
}
