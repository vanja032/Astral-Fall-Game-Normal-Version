using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForce : MonoBehaviour {
    public float rndforce1;
    public float rndforce2;
    public float rndforce3;
    public Rigidbody rg;
    public int bro;
	// Use this for initialization
	void Start () {
        bro = 0;
        rndforce1 = Random.Range(-50, 50);
        rndforce2 = Random.Range(-50, 50);
        rndforce3 = Random.Range(-50, 50);
        rg = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        bro++;
        if(bro<25)
        { 
        rg.AddForce(new Vector3(rndforce1, rndforce2, rndforce3));
        }

    }
}
