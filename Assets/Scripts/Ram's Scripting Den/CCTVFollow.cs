using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVFollow : MonoBehaviour
{
    public Transform target;
    public float delay = 1;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);
    }

    private void FixedUpdate()
    {
        var rotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * delay);

    }

    
}
