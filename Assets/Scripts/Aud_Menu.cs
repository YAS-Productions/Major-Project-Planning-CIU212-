using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class Aud_Menu : MonoBehaviour
{
    public void MenuClick()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/UI_Click");
    }
    public void MenuHover()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/UI_Rollover");
    }
    public void MenuPause()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/UI_Pause");
    }
}
