using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorMelon_Trigger : MonoBehaviour
{
    public GameObject melon;
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
        if (other.CompareTag("Player"))
        {
            melon.GetComponent<Rigidbody>().isKinematic = false;
            melon.GetComponent<destruction>().AutoDestroy = true;

        }
    }
}
