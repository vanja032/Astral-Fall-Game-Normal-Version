using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RndRotating : MonoBehaviour {
    public float xrot;
    public float yrot;
    public float zrot;

    // Use this for initialization
    void Start () {
        yrot = Random.Range(-15.0f, 15.0f);
        xrot = Random.Range(-20.0f, 20.0f);
        zrot = Random.Range(-180.0f, 180.0f);
        transform.Rotate(xrot, yrot, zrot);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
