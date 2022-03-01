using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBank_UnlockSurveillance : MonoBehaviour
{
    [SerializeField]
    private bool unlocked;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            UnlockDoor();
        }
    }

    public void UnlockDoor()
    {
        unlocked = true;
        return;
      
    }
}
