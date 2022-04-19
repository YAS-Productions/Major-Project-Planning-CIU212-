using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscButtonFix : MonoBehaviour
{

    public GameObject inputThing;
    public GameObject optionsThing;
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
                inputThing.SetActive(false);
                optionsThing.SetActive(true);
            }


        }
    }
}
