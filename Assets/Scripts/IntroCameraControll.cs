using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCameraControll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Input.gyro.enabled = true;
        // transform.Rotate(-Input.gyro.rotationRateUnbiased.x, Input.gyro.rotationRateUnbiased.y, Input.gyro.rotationRateUnbiased.z);
        transform.Rotate(0.1f,0.1f,0.1f);
    }
}
