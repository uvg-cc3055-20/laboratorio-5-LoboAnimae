using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
	private float time;
	private bool objectStatus;
	public GameObject child;
	private float timeHelper;

	// Use this for initialization
	void Start () {
		time = 0f;
		objectStatus = true;
		timeHelper = 0f;

	}
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		timeHelper = timeHelper + Time.deltaTime;
		if (timeHelper >= 5f) {
			
			Debug.Log ("Change");
		}
		if ( timeHelper >= 5f ) {
			
			if (objectStatus == true) {
				child.SetActive (false);
				objectStatus = false;
				Debug.Log ("Status = true");

			}
			else if( objectStatus == false)
			{
				child.SetActive (true);
				objectStatus = true;
				Debug.Log ("Status = False");
			
			}
			timeHelper = 0f;
		}

	}
}

