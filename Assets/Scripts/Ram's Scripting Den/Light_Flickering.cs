using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Flickering : MonoBehaviour
{
    public float min;
    public float max;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().intensity = Random.Range(min, max);
    }
}
