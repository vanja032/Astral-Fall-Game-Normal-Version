using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPucanjSameKugle : MonoBehaviour {
    public AudioSource ass;
    public AudioClip acc;
	// Use this for initialization
	void Start () {
        ass = this.GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {
		//if(ShootingObstacle.prmetka==false && ShootingObstacle.prbroja==true && ShootingObstacle.brojpom>=69)
        //{
            //if(ShootingObstacle.brojpom >= 71)
            //{
                //ShootingObstacle.broj = 0;
            //}
            ass.Play();
        Destroy(this);
        //}
	}
}
