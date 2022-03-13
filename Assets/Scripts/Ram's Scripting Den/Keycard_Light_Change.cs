using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard_Light_Change : MonoBehaviour
{
    public GameObject keycardScanner;
    public Material unlockedMat;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.y > 0)
        {
            Debug.Log("Triggered");
            keycardScanner.GetComponent<Animator>().enabled = false;
            Material mat = keycardScanner.GetComponent<MeshRenderer>().material;
            mat.SetColor("_BaseColor", Color.green);
            mat.DisableKeyword("_EMISSION");
            
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("Door"))
    //    {
    //        Debug.Log("Triggered");
    //        Material mat = keycardScanner.GetComponent<Renderer>().material;
    //        mat.SetColor("_EmissionColor", Color.green);
    //    }
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.CompareTag("Door"))
    //    {
    //        Debug.Log("Triggered");
           
    //    }
    //}
}
