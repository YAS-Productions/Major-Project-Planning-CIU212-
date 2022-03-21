using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeanieAudController : MonoBehaviour
{
    public void PaperInteraction() /* Paper up or down */
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D_Interaction/Paper_Toggle");
    }
    public void MetalInteraction()
    {
        //play metal sound
    }
    public void SoftInteraction() /* Great for objects not metal - plastics, fabrics etc */
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D_Interaction/TexturedObject_Toggle");
    }
}