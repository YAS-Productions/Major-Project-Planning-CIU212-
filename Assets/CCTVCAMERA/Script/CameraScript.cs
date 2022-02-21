using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{


	public GameObject CameraMain;  
	public Transform target;
	public float maxAngleX = 30f;
	public float maxAngleY = 30f;
	private Vector3 fixedForward;
	private Vector3 fixedUpwards;

	// Use this for initialization
	void Start ()
	{
		fixedForward = transform.forward;
		fixedUpwards = transform.up;
	}

	// Update is called once per frame
	void Update ()
	{
		//Calculates Vector from target to camera position to compare to the foward vector
		Vector3 OriginalVector = target.position - CameraMain.transform.position;

		//Calculates Angle between UP or Foward Angle 
		float angle = Vector3.Angle(OriginalVector, fixedForward);
		float angleY = Vector3.Angle (OriginalVector, fixedUpwards);

		//Checks if Angle is inferior of Max angle allowed by user , if yes ,  uses LookAt to point camera to the object beeing tracked , in this case Target 
		if (angle < maxAngleX)
		{
			CameraMain.transform.LookAt(target);
		}
		if (angleY < maxAngleY)
		{
			CameraMain.transform.LookAt(target);
		}
	}
		
}