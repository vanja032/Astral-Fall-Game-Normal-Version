using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTurnOffScreenDisable : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
