using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySustanje : MonoBehaviour {
    public AudioSource aa;
    //public AudioClip ac;
	// Use this for initialization
	void Start () {
        aa = this.GetComponent<AudioSource>();
        aa.Pause();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            aa.Play();
            Destroy(this);
        }
	}
}
