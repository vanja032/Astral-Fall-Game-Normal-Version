using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlomiPoenKuglu : MonoBehaviour {
    public float pele;
    public GameObject[] gameObjects;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pele= PlayerPrefs.GetFloat("pizidibizi", pele);
        if (AccelerometerInputCam.udarlopte == true)
        {
            //Destroy(this.gameObject);
        }
        if (pele == 2)
        {
           
        }
    }
    /*private void OnCollisionEnter(Collision collisionni)
    {
        
        if(collisionni.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
        }
    }*/
}
