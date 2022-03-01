using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBank_LightsTrigger : MonoBehaviour
{
    public GameObject[] lights;

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
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].SetActive(false);
            }
        }
    }
}
