using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Progression : MonoBehaviour
{
    [SerializeField]
    private bool door2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            door2 = true;
        }
    }




    public bool UnlockDoor2()
    {
        if (door2 == true)
        {
            return true;
        }
        else return false;
        
    }
}
