//Written by Jack
using System.Collections;
using UnityEngine;

public class Footstep_Detector : MonoBehaviour
{
    [Header("Audio Settings")]
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;
    [Range(-1f, 1f)]
    public float panStereo;

    [Range(0f, 2f)]
    public float delay;

    [Space(10)]
    [Header("Surface Arays")]
    public AudioClip[] bldInterior;
    public AudioClip[] badwalking;
    public AudioClip[] grassyTerrain;
    public AudioClip[] glass;
    public AudioClip[] creakywood;

    [Space(10)]
    [Header("Components")]
    public AudioSource audioSource;
    public Transform cam;
    Player_Controller controller;

    void Awake()
    {
        controller = GetComponent<Player_Controller>();
        audioSource.volume = volume;
        audioSource.pitch = pitch;
        audioSource.panStereo = panStereo;

        //Plays the footstep sound when the game starts depending on the surface the player is standing on 
        RaycastHit detect;
        string floortag;
        if (Physics.Raycast(cam.position, Vector3.down, out detect, 3f))
        {
            floortag = detect.collider.tag;

            if (detect.collider.tag == "bldInterior")
            {

                audioSource.clip = bldInterior[Random.Range(0, bldInterior.Length)];
                audioSource.Play();
            }
            else if (floortag == "badwalking")
            {
                audioSource.clip = badwalking[Random.Range(0, badwalking.Length)];
                audioSource.Play();
            }
            else if (floortag == "grassyTerrain")
            {
                audioSource.clip = grassyTerrain[Random.Range(0, grassyTerrain.Length)];
                audioSource.Play();
            }
            else if (floortag == "Glass")
            {
                audioSource.clip = glass[Random.Range(0, glass.Length)];
                audioSource.Play();
            }
            else if (floortag == "creakywood")
            {
                audioSource.clip = creakywood[Random.Range(0, creakywood.Length)];
                audioSource.Play();
            }

        }
    }

    // Use this for initialization
    IEnumerator Start()
    {
        while (true)
        {
            RaycastHit hit = new RaycastHit();
            string floortag;
            //plays footstep sounds when the player is on the ground and moving
            if (controller.isGrounded == true )
            {
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                {
                    if (Physics.Raycast(cam.position, Vector3.down, out hit, 3f))
                    {
                        floortag = hit.collider.tag;
                        //Plays footsetp sounds depending on the tag of the surface the player is on
                        if (hit.collider.tag == "bldInterior")
                        {

                            audioSource.clip = bldInterior[Random.Range(0, bldInterior.Length)];
                            audioSource.Play();
                        }
                        else if (floortag == "badwalking")
                        {
                            audioSource.clip = badwalking[Random.Range(0, badwalking.Length)];
                            audioSource.Play();
                        }
                        else if (floortag == "grassyTerrain")
                        {
                            audioSource.clip = grassyTerrain[Random.Range(0, grassyTerrain.Length)];
                            audioSource.Play();
                        }
                        else if (floortag == "Glass")
                        {
                            audioSource.clip = glass[Random.Range(0, glass.Length)];
                            audioSource.Play();
                        }
                        else if (floortag == "creakywood")
                        {
                            audioSource.clip = creakywood[Random.Range(0, creakywood.Length)];
                            audioSource.Play();
                        }

                    }              
                }
                
                yield return new WaitForSeconds(audioSource.clip.length + delay);
            }
            else
            {
                yield return 0;
            }
        }


    }
}
