using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MovingCamera : MonoBehaviour {
    public GameObject cam;
    public Rigidbody rg;
    public float xa, za;
    public CharacterController lopta;
    public float hzMovement = 0, vtMovement = 0;
    public float brpr;
    public float zatstart = 0;
    public float xatstart = 0;
    public Vector3 moveDirection;
    public int hj;
    public GameObject gmobjadded;
    public float rx;
    public float ry;
    public float rz;
    public bool vv;
    public float fx;
    public float fy;
    // Use this for initialization
    void Start () {
        fx = 0;fy = 0;
        vv = false;
        gmobjadded=  (GameObject)Instantiate(Resources.Load("RasturenaLopta"));
        rx = 0;ry = 0;rz = 0;
        hj = 0;
        brpr = 0;
        xa = 0; za = 0;
        Centralizacija();
        xatstart = 0;
        zatstart = 0;
        hzMovement = 0;
        vtMovement = 0;
        rx = Random.Range(-5f, 5f);
        ry = Random.Range(-5f, 5f);
        rz = Random.Range(-5f, 5f);

    }
	
	// Update is called once per frame
	void Update () {
        
        brpr++;
        if(brpr<30)
        {
            Centralizacija();
        }
        hzMovement = Input.acceleration.x - xatstart;
        vtMovement = -Input.acceleration.z + zatstart;
        if (brpr >= 80)
        {
            if(WritingTextForIntro.brzinabool==false && DetektujNaStartuKolizijuSaDaskom.pr==false)
            { 
                moveDirection = new Vector3(hzMovement * 2.1f, vtMovement * 2.1f, 0.7f);
                //cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.z,0.7f);
            }
            if (WritingTextForIntro.brzinabool == true && DetektujNaStartuKolizijuSaDaskom.pr == false)
            {
                moveDirection = new Vector3(hzMovement * 2.1f, vtMovement * 2.1f, 2.5f);
                //cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.z,0.7f);
                fx = hzMovement * 2.1f;fy=vtMovement * 2.1f;
            }
            if(DetektujNaStartuKolizijuSaDaskom.pr == true && hj<40)
            {
                //rg.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
                hj++;
                moveDirection = new Vector3(fx,fy, (-0.8f));
                //rg.transform.eulerAngles = new Vector3(0,0,0);
                //rg.transform.Rotate(rg.rotation.x - rx, rg.rotation.y - ry, rg.rotation.z - rz);

            }
            if (DetektujNaStartuKolizijuSaDaskom.pr == true && vv == false)
            {
                Instantiate(gmobjadded, new Vector3(cam.transform.position.x, cam.transform.position.y, rg.transform.position.z-1), Quaternion.identity);
                Instantiate(gmobjadded, new Vector3(cam.transform.position.x, cam.transform.position.y, rg.transform.position.z - 1), Quaternion.identity);
                vv = true;
            }

        }
        if(brpr<80)
        {
            moveDirection = new Vector3(0, 0, 0.7f);
        }
        if(hj<40)
        { lopta.Move(moveDirection); }
        if(hj>=40)
        {
            hj++;
            //cam.transform.eulerAngles = new Vector3(0,0,0);
            //rg.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
        }
        if(hj>=88)
        {
            SceneManager.LoadScene("Start");
        }
    
        

        //Input.acceleration.x*70

        if (cam.transform.position.z>272)
        {
           // SceneManager.LoadScene("Start");
        }
    }
    void Centralizacija()
    {
        xatstart = Input.acceleration.x;
        zatstart = Input.acceleration.z;
    }


}
