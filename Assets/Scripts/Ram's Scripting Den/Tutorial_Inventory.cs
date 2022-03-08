using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Inventory : MonoBehaviour
{

    public GameObject tut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            Destroy(tut);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            tut.SetActive(true);
        }
        
    }
}
