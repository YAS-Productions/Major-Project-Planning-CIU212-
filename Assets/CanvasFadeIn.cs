using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasFadeIn : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public GameObject player;
    public Camera cutsceneCam;

    // Start is called before the first frame update
    void Start()
    {
        //canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            FadeOut();
        }
        if (Input.GetKey(KeyCode.L))
        {
            FadeIn();
        }
    }

    public void FadeOut()
    {
        StartCoroutine(StartFading());
    }

    public void FadeIn()
    {
        StartCoroutine(StartUnFading());
    }

    IEnumerator StartFading()
    {
       
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;

    }
    IEnumerator StartUnFading()
    {
        //canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha != 1)
        {
            canvasGroup.alpha += Time.deltaTime * 1;
            yield return null;
        }


        canvasGroup.interactable = true;
        yield return null;

    }

    public void StartPlayer()
    {
        player.GetComponent<characterMovement>().enabled = true;
        cutsceneCam.depth = 0;
    }
}
