using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVFollow : MonoBehaviour
{
    public Transform target;
    public float delay = 1;
    // Start is called before the first frame update
    private GameObject player;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);
    }

    private void FixedUpdate()
    {
        var rotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * delay);

    }

    
}
