using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_Monitor : MonoBehaviour
{
    public GameObject[] monitors;
    //float intensity = 0.01f;
    public GameObject[] staticMonitors;

    public Animator lever;
    //public GameObject interactTut;

    public GameObject vaultDoor;
    public GameObject lightsTrigger;
    

    // Start is called before the first frame update
    void Start()
    {
        lever.GetComponent<Animator>();
       
        
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.O))
    //    {
    //        TriggerVaultDoor();
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                for (int i = 0; i < monitors.Length; i++)
                {
                    Material mat = monitors[i].GetComponent<Renderer>().material;
                    mat.SetFloat("Vector1_3AB71CF9", 1);

                    


                    //mat.EnableKeyword("_EMISSION");

                    //mat.SetColor("_EmissionColor", new Color(0, 191, 160) * intensity);
                }

                for (int i = 0; i < staticMonitors.Length; i++)
                {
                    Material staticMat = staticMonitors[i].GetComponent<Renderer>().material;
                    staticMat.EnableKeyword("_EMISSION");
                }

                lever.SetBool("isActivated", true);
                TriggerVaultDoor();
                lightsTrigger.GetComponent<TheBank_LightsTrigger>().TurnOnLights();
            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("Player"))
    //    {
    //        interactTut.SetActive(true);
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if(other.CompareTag("Player"))
    //    {
    //        interactTut.SetActive(false);
    //    }
    //}

    void TriggerVaultDoor()
    {
        vaultDoor.transform.Rotate(0, 90, 0);
        //Destroy(interactTut);
        
        //Destroy(this);
        

    }

}
