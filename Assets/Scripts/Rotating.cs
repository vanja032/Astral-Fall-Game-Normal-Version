using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {
    public CapsuleCollider ball;
    public float pbrot;
    public int br=0;
    public bool prov = false;
    public int rotatebr;
	// Use this for initialization
	void Start () {
        ball = FindObjectOfType<CapsuleCollider>();
        rotatebr = Random.Range(800, 1500);
    }
	
	// Update is called once per frame
	void Update () {
        pbrot = ball.transform.position.z/500;
        if(br<0)
        {
            prov = false;
            rotatebr = Random.Range(800, 1500);
        }
        if (br > rotatebr)
        {
            prov = true;
        }
        if(prov==false)
        { transform.Rotate(new Vector3(0, 0, 1), 25 * Time.deltaTime); br++; }
        if (prov == true)
        { transform.Rotate(new Vector3(0,0,1), 25 * Time.deltaTime); br--; }


        

    }
}
