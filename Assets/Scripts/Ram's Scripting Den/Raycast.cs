using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    Camera mainCam;

    [SerializeField]
    private GameObject icon;
    public float raycastDistance;
    private bool canTurnOff;

    TheBank_LightsTrigger theBank_LightsTrigger;

    // Start is called before the first frame update
    void Start()
    {
        icon = GameObject.FindGameObjectWithTag("FuseIcon");

        mainCam = GetComponent<Camera>();
        theBank_LightsTrigger = GameObject.FindObjectOfType(typeof(TheBank_LightsTrigger)) as TheBank_LightsTrigger;
    }

    // Update is called once per frame
    void Update()
    {
        icon = GameObject.FindGameObjectWithTag("FuseIcon");

        Ray ray = mainCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * raycastDistance, Color.blue);
        if(Physics.Raycast(ray, out hit, raycastDistance))
        {
            print(hit.transform.name);

        }
        if (hit.transform.tag == "TriggerIcon")
        {
            icon.GetComponent<SpriteRenderer>().enabled = true;
            canTurnOff = true;

        }
        else
        {
            icon.GetComponent<SpriteRenderer>().enabled = false;
            canTurnOff = false;
        }

        if (canTurnOff == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("LightsOff");
            theBank_LightsTrigger.TurnOffLights();
        }


    }
}
