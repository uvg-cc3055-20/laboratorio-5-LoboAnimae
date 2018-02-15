using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	/*
	*@author Andres Quan Littow 17652
	*/ 
public class Weight : MonoBehaviour {
	
	//Creates the line in the visible plane
	LineRenderer line;
	
	//Distance default join
	DistanceJoint2D distanceJoint;
	// Use this for initialization
	void Start () {
		distanceJoint = GetComponent<DistanceJoint2D> ();
		line = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		//Sets position of line from weight to object
		line.SetPosition (0, transform.position);
		
		//Allows the movement of the line
		line.SetPosition (1, distanceJoint.connectedBody.transform.position);

	}
}
