using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	/*
	*@author Andres Quan Littow 17652
	*/ 
public class AreaEffector : MonoBehaviour {
	private float time;
	private bool objectStatus;
	public GameObject child;
	private float timeHelper;

	// Variable Initialization
	void Start () {
		time = 0f;
		objectStatus = true;
		timeHelper = 0f;

	}
	
	// Variable and Context Update
	void Update () {
		//Loop for time addition
		time = time + Time.deltaTime;
		
		//Helper that resets every 5 seconds for the system to work. 
		timeHelper = timeHelper + Time.deltaTime;
		
		//If statement to Debug
		if (timeHelper >= 5f) {
			
			Debug.Log ("Change");
		}
		
		//If statement that changes the status of clouds to let the player through
		if ( timeHelper >= 5f ) {
			
			//This If statement changes it from true to false every 5 seconds
			if (objectStatus == true) {
				child.SetActive (false);
				objectStatus = false;
				Debug.Log ("Status = true");

			}
			
			//This If statement changes it from false to true every 5 seconds
			else if( objectStatus == false)
			{
				child.SetActive (true);
				objectStatus = true;
				Debug.Log ("Status = False");
			
			}
			
			//Resets the timer for status change
			timeHelper = 0f;
		}

	}
}

