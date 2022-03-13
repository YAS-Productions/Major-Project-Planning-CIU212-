using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Intro_Cutscene : MonoBehaviour
{
    public GameObject globalVolume;
    Volume volume;
    Vignette vignette;

    // Start is called before the first frame update
    void Start()
    {
        volume = globalVolume.GetComponent<Volume>();
        
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VignetteUp()
    {
        volume.weight += 0.1f;
    }

    public void VignetteDown()
    {
        volume.weight -= 0.1f;
    }
}
