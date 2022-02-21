using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cant_access_area : MonoBehaviour
{
    public GameObject cantAccessArea;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            cantAccessArea.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            cantAccessArea.SetActive(false);
        }
    }
}
