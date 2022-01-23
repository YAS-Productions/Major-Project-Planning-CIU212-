using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_PopUp : MonoBehaviour
{
    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        UI.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        UI.SetActive(false);
    }
}
