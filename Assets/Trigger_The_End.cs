using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_The_End : MonoBehaviour
{
    public GameObject endCanvas;
    public GameObject endCutscene;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject mainCam;
    [SerializeField]
    private GameObject reticule;

    public GameObject finalFilm;

    public GameObject credits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");
        reticule = GameObject.Find("Reticule");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            endCanvas.GetComponent<CanvasFadeIn>().StartCoroutine("StartUnFading");
            Invoke("FadeOut", 3.5f) ;
            Destroy(mainCam, 3);
            Destroy(player, 3);
            
        }
    }

    void FadeOut()
    {
        endCanvas.GetComponent<CanvasFadeIn>().StartCoroutine("StartFading");
        endCutscene.SetActive(true);
        reticule.SetActive(false);
    }

    void CrossingSignals()
    {
        finalFilm.SetActive(true);
    }

    void RollCredits()
    {
        credits.SetActive(true);
    }
}
