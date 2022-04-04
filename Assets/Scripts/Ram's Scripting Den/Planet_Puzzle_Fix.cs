using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Puzzle_Fix : MonoBehaviour
{
    public MeshRenderer mercury;
    public MeshRenderer mercuryToy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mercuryToy.GetComponent<MeshRenderer>().enabled == false)
        {
            mercury.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
