using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingParticleS : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    //public GameObject p2;
    public GameObject mc;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        p1.transform.position = new Vector3(0.1f,0.1f,mc.transform.position.z+27);
        p2.transform.position = new Vector3(0.1f, 0.1f, mc.transform.position.z + 27);

    }
}
