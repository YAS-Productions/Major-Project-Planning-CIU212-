using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_SetActive : MonoBehaviour
{
    public GameObject GO;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameObject_SetActive()
    {
        GO.SetActive(true);
    }
}
