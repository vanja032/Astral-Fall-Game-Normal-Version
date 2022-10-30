using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetektujNaStartuKolizijuSaDaskom : MonoBehaviour {
    public static bool pr;
    public bool pompr;
	// Use this for initialization
	void Start () {
        //pr = false;
        //pompr = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collisionin)
    {
        if(collisionin.gameObject.tag == "Finish")
        {
            pr = true;
            pompr = true;
        }
    }
   
}
