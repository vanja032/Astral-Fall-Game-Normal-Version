using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {
    public AudioSource melodija;
    
    public bool pr;
    public bool pr2;
    public bool pr3;
    public AudioClip boom;
    public AudioClip song;
    public AudioClip boomballs;
    public AudioClip pucanje;
    public bool izi;
    // Use this for initialization
    void Start () {
        izi = false;
        melodija.clip = song;
        melodija.playOnAwake = true;
        
        
        melodija.loop = true;
        pr = false;
        pr2 = false;
        pr3 = false;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (DetectCollision.prcolis == true)
        {

           
            //melodija.Stop();
            melodija.clip = boom;
            
            if (pr==false)
            {
                melodija.Play();
                melodija.loop = false;
                pr = true;
            }
            
        }
        if (AccelerometerInputCam.udarlopte == true)
        {
            if(pr2==false)
            {

                melodija.PlayOneShot(boomballs);
                
                
                pr2 = true;
                pr3 = false;
            }
            
            
        }
        if(AccelerometerInputCam.udarlopte == false)
        {
            pr2 = false;
            
        }
        
        if(SlomiDask.dasek1==true && izi==false)
        {
            melodija.PlayOneShot(pucanje);
            izi = true;
        }
        if(SlomiDask.dasek1 == false)
        {
            izi = false;
        }
        




    }
}
