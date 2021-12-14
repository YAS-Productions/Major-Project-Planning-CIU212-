using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomYearAppear : MonoBehaviour
{
    public GameObject canvas;
    private AudioSource audioSource;
    public AudioClip boom;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerYear()
    {
        canvas.SetActive(true);
        audioSource.PlayOneShot(boom);
        Destroy(canvas, 3);
    }
}
