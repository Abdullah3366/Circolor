using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobilecontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()   
	{
		foreach (Touch touch in Input.touches) {
			if (touch.position.x < Screen.width/2)  //Rotate according to touch position
			{                                        
				transform.Rotate(new Vector3(0,0,1), 300f * Time.deltaTime);
			}
			else if (touch.position.x > Screen.width/2)
			{
				transform.Rotate(new Vector3(0,0,1), -300f * Time.deltaTime);
			}

		}
	}
}
