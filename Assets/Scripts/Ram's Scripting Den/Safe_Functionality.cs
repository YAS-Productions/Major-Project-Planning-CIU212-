using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe_Functionality : MonoBehaviour
{
    public GameObject[] wheels;
    [SerializeField]
    private int wheelIndex = 0;
    [SerializeField]
    private bool bigWheel;
    [SerializeField]
    private bool midWheel;
    [SerializeField]
    private bool smallWheel;

    public GameObject safeDoor;
    focusCamEffect focusCamEffect;

    bool safeOpened;


    // Start is called before the first frame update
    void Start()
    {
        wheelIndex = wheels.Length;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (wheelIndex <= 0)
            {
                wheelIndex = 2;
            }
            else
            {
                wheelIndex -= 1;
            }


        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (wheelIndex >= wheels.Length - 1)
            {
                wheelIndex = 0;
            }
            else
            {
                wheelIndex += 1;
            }
        }



        //TESTING//
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    OpenSafe();
        //}



        //ROTATING WHEELS/////////////////
        if (Input.GetKey(KeyCode.A))
        {
            wheels[wheelIndex].transform.Rotate(new Vector3(0, 0, 30f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            wheels[wheelIndex].transform.Rotate(new Vector3(0, 0, -30f) * Time.deltaTime);
        }




        //SOLUTION//////////////////////
        if (wheels[0].transform.localRotation.eulerAngles.z >= 45 && wheels[0].transform.localRotation.eulerAngles.z <= 50)
        {
            bigWheel = true;
        }
        else bigWheel = false;

        if (wheels[1].transform.localRotation.eulerAngles.z >= 15 && wheels[1].transform.localRotation.eulerAngles.z <= 20)
        {
            midWheel = true;
        }
        else midWheel = false;

        if (wheels[2].transform.localRotation.eulerAngles.z >= 165 && wheels[2].transform.localRotation.eulerAngles.z <= 170)
        {
            smallWheel = true;
        }
        else smallWheel = false;

        if (bigWheel == true && smallWheel == true && midWheel == true)
        {
            Debug.Log("Safe Unlocked");
            OpenSafe();
            
        }

        

        //OPENING SAFE/////////////// (CHANGE THIS TO MAKE IT SMOOTH USING COROUTINE)
        void OpenSafe()
        {
            
            //safeDoor.transform.Rotate(new Vector3(0, -180, 0));
            //safeDoor.transform.rotation = Quaternion.Lerp(safeDoor.transform.rotation, Quaternion.Euler(0, 1200, 0), Time.deltaTime * 5); /// WORKS BUT ITS NOT SMOOTH
            StartCoroutine(RotateSafeDoor(180));
            //safeOpened = true;
            /* focusCamEffect.StartCoroutine("I_MoveCameraToDefaultPosition");*/ //DOESNT WORK
        }


        //TESTING///////////////
        IEnumerator RotateSafeDoor(float rotationAmount)
        {
            Quaternion finalRotation = Quaternion.Euler(0, rotationAmount, 0) * safeDoor.transform.rotation;
            while (safeDoor.transform.rotation != finalRotation/* && safeOpened == false*/)
            {
                safeDoor.transform.rotation = Quaternion.Lerp(safeDoor.transform.rotation, finalRotation, Time.deltaTime);
                yield return 0;
               

            }

        }
    }
}
