using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour {
    public ParticleSystem pp;
    public bool pr;
	// Use this for initialization
	void Start () {
        pr = false;
        //pp = this.gameObject.GetComponent<ParticleSystem>();
        //pp = this.GetComponent<ParticleSystem>();
        //GetComponent<ParticleSystem>().Stop();
        //pp.Stop();
        //pp.Clear();
    }
	
	// Update is called once per frame
	void Update () {
        
		if(ShootingObstacle.pukni==true)
        {
            pr = true;
            
        }
        if(pr==true)
        {
            //pp.Play();
        }
	}
}
