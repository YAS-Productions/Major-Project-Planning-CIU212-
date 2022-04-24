using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize_Dialogue : MonoBehaviour
{
    public GameObject KF_Dialogue_Welcome;
    public GameObject dialogue;

    private void Start()
    {
        Invoke("PlayDialogue", 6.6f);
    }


    #region KF
    void PlayDialogue()
    {
        KF_Dialogue_Welcome.SetActive(true);
    }

    #endregion

    #region Overall
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            dialogue.SetActive(true);
        }
    }
    #endregion

}
