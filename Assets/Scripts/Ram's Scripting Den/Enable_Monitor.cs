using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_Monitor : MonoBehaviour
{
    public GameObject[] monitors;
    float intensity = 0.01f;

    public Animator lever;
    public GameObject interactTut;

    public GameObject vaultDoor;

    // Start is called before the first frame update
    void Start()
    {
        lever.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            TriggerVaultDoor();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            if(Input.GetKeyDown(KeyCode.E))
            {
                for (int i = 0; i < monitors.Length; i++)
                {
                    Material mat = monitors[i].GetComponent<Renderer>().material;
                    mat.EnableKeyword("_EMISSION");
                    mat.SetColor("_EmissionColor", new Color(0, 191, 160) * intensity);
                }

                lever.SetBool("isActivated", true);
                TriggerVaultDoor();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            interactTut.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            interactTut.SetActive(false);
        }
    }

    void TriggerVaultDoor()
    {
        vaultDoor.transform.Rotate(0, 90, 0);
    }

}
