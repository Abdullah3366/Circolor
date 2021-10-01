using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	void Start () {

        Invoke("disableanimation", 1f);
	}
	
	// Update is called once per frame
	void Update () //Basic Rotation functionality
	{
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(new Vector3(0,0,1), -300f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate(new Vector3(0,0,1), 300f * Time.deltaTime);
		}
	}

    void disableanimation()  //Disables ring rotation animation 1 second after beign created
    {
        GetComponent<Animator>().enabled = false;
    }
}
