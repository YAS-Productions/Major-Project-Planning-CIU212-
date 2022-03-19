using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepDetector : MonoBehaviour
{
    Transform player;
    Rigidbody character;
    characterMovement controller;
    public Collider playerCollider;
    bool isGrounded;
    bool walking;
    float currentSpeed;
    float distanceCoverd;
    RaycastHit hit;
    void Start()
    {
        controller = FindObjectOfType<characterMovement>();
        player = gameObject.transform;
        character = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = PlayerGrounded();
        currentSpeed = character.velocity.magnitude;
        walking = CheckIfWalking();

        if (walking)
        {
            distanceCoverd += (currentSpeed * Time.unscaledDeltaTime) * 0.5f;
            if (distanceCoverd > 1 && isGrounded)
            {
                PlayFootStepTag();              
                distanceCoverd = 0;
            }
        }  
    }

    bool CheckIfWalking()
    {
        if (currentSpeed > 0 && isGrounded)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool PlayerGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, out hit, playerCollider.bounds.extents.y + 0.5f);
    }
    public void PlayFootStepTag()
    {
        if(hit.collider.tag == "Wood_Floor")
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Footsteps/Wood");
        }
        else if (hit.collider.tag == "Rug_Floor")
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Footsteps/Rug");
        }
        else if (hit.collider.tag == "BluntW_Floor")
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Footsteps/Bluntwood");
        }
        else if (hit.collider.tag == "Concrete_Floor")
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Footsteps/Concrete");
        }
    }
}
