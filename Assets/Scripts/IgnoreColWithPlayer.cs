using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreColWithPlayer : MonoBehaviour {
    public Collider bal;
    public Collider bulet;
	// Use this for initialization
	void Start () {
        bal = GameObject.FindWithTag("Player").GetComponent<Collider>();
        bulet = this.gameObject.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        Physics.IgnoreCollision(bal, bulet);
		
	}
}
