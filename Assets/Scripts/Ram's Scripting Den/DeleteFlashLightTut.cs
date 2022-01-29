using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFlashLightTut : MonoBehaviour
{
    MeshRenderer m_rend;
    BoxCollider b_coll;
    MeshCollider m_coll;
    // Start is called before the first frame update
    void Start()
    {
        m_rend = GetComponent<MeshRenderer>();
        b_coll = GetComponent<BoxCollider>();
        m_coll = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(m_rend.enabled == false)
        {
            b_coll.enabled = false;
            m_coll.enabled = false;
        }
    }
}
