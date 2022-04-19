using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscButtonFix : MonoBehaviour
{
    public GameObject inputThing;
    public CanvasGroup inputCanvas;
    public CanvasGroup optionsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inputThing.activeInHierarchy)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                inputCanvas.alpha = 0;
                optionsCanvas.alpha = 1;
            }


        }
    }
}
