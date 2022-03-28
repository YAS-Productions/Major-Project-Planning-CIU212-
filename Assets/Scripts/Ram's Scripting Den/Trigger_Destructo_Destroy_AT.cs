using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Destructo_Destroy_AT : MonoBehaviour
{
    public GameObject destuctoGO;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TriggerDestroy()
    {
        destuctoGO.GetComponent<destruction>().AutoDestroy = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            TriggerDestroy();
        }
    }
}
