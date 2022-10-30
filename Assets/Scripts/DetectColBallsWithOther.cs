using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColBallsWithOther:MonoBehaviour
{
    static bool prball1;
    public bool prballpom1;
    // Use this for initialization
    void Start () {
        prball1 = false;
        prballpom1 = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        prball1 = true;
        prballpom1 = true;
    }
}
