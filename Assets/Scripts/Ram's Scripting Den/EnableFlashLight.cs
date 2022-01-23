using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFlashLight : MonoBehaviour
{
    public GameObject flashlight;
    public GameObject inventoryFlashlight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(flashlight.activeInHierarchy == false)
        {
            inventoryFlashlight.SetActive(true);
        }
    }

   
}
