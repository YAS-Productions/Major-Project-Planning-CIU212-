using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_Monitor : MonoBehaviour
{
    public GameObject monitor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            Material mat = monitor.GetComponent<Renderer>().material;
            mat.SetColor("_EmissionColor", Color.white);
        }
    }


  
    // Testing monitor changing V of HSV**********************************
  
    private void OnTriggerEnter(Collider other)
    {
       

        if (other.CompareTag("Player"))
        {
          

        }
    }
}
