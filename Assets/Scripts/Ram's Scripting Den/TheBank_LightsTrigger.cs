using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBank_LightsTrigger : MonoBehaviour
{
    public GameObject[] lights;
    public GameObject tutorial;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            tutorial.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                TurnOffLights();
                tutorial.SetActive(false);
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tutorial.SetActive(false);
        }
    }

    void TurnOffLights()
    {
        Debug.Log("KeyPressed");
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].SetActive(false);
        }



    }

    public void TurnOnLights()
    {
        Debug.Log("Meant to be On");
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].SetActive(true);
        }
        //tutorial.SetActive(false);
    }
}
