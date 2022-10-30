using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicsDel : MonoBehaviour {
    public Collider cam;
    public Collider spher;
    public Collider goldbal;
	// Use this for initialization
	void Start () {
        goldbal = this.gameObject.GetComponent<Collider>();
        spher = GameObject.FindWithTag("Player").GetComponent<Collider>();
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
        //Physics.IgnoreCollision(cam,goldbal);
        //Physics.IgnoreCollision(spher, goldbal);
    }
}
