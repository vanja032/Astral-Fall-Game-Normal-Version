using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetColBalls : MonoBehaviour {
    public static bool prball;
    public bool prballpom;
	// Use this for initialization
	void Start () {
        prball = false;
        prballpom = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        prball = true;
        prballpom = true;
    }
    void OnCollisionExit(Collision cole)
    {
        prball = false;
        prballpom = false;
    }
}
