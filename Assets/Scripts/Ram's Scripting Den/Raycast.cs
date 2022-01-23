using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    Camera mainCam;
    
    public GameObject interactTut;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 4))
        {
            print(hit.transform.name);
            
        }
        if(hit.transform.tag == "Item")
        {
            interactTut.SetActive(true);
        }
        else
        {
            interactTut.SetActive(false);
        }
    }
}
