using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestructoIcon : MonoBehaviour
{

    public GameObject destructoIcon;
    [SerializeField]
    private GameObject player;

    public GameObject bottle;
    public GameObject bottle2;
    public GameObject bottle3;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if(bottle == null && bottle2 == null && bottle3 == null)
        {
            Destroy(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            destructoIcon.SetActive(true);
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            destructoIcon.SetActive(false);
        }
    }


}
