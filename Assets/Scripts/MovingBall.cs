using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingBall : MonoBehaviour {
    public bool prr;
    public bool preditora;
    public float rx;
    public float ry;
    public float rz;
    public static float stbrz;
    public bool detectudar = false;
    public bool trzz = false;
    public float brzz = 18;
    public Collider ball;
    public BoxCollider boxc;
    public SphereCollider spherec;
    public CapsuleCollider kam;
    public Rigidbody ballobj;
    public GameObject bals;
    public GameObject loptice;
    public GameObject mainkam;
    public bool posz = false;
    public bool prcolis;
    public int gozi=0;
    public bool udaz;
    public ParticleSystem part;
    public ParticleSystem varnice;
    public bool edit;
    // Use this for initialization
    void Start () {
        varnice = GameObject.FindWithTag("biskut").GetComponent<ParticleSystem>();
        part = GameObject.FindWithTag("biskut1").GetComponent<ParticleSystem>();
        edit = false;
        preditora = false;
        float rx = 0;
        float ry = 0;
        float rz = 0;
        prr = false;
        bals = GameObject.FindWithTag("Player");
        loptice = (GameObject)Instantiate(Resources.Load("Loptice"));
        gozi = 0;
        udaz = false;
    }
	
	// Update is called once per frame
	void Update () {


        stbrz = brzz;
        part.playbackSpeed = brzz/6;
        varnice.playbackSpeed = brzz/2;
        if(ZidDetect.przida==false)
        {
            varnice.Stop();
            varnice.Clear();
        }
        else
        {
            varnice.Play();
        }
        if (DetectCollision.prcolis == true)
        {
            
            varnice.Stop();
            varnice.Clear();
            part.Stop();
            part.Clear();

        }
        if(AccelerometerInputCam.udarlopte==true)
        {
            varnice.Play();
            udaz = true;
        }
        if (AccelerometerInputCam.udarlopte == false && udaz==true)
        {
            varnice.Stop();
            varnice.Clear();
            udaz = false;
        }


            if (DetectCollision.prcolis==false)
        {
            transform.Translate(Vector3.forward * brzz * Time.deltaTime);

            brzz = 30 + ball.transform.position.z / 150;
        }
        if(DetectCollision.prcolis == true)
        {
            Destroy(GameObject.FindWithTag("Brobst"));
            //ballobj.useGravity = enabled;
            gozi++;
            if(prr==false)
            {
                rx = Random.Range(-0.15f, 0.15f);
                ry = Random.Range(-0.15f, 0.15f);
                rz = Random.Range(-0.15f, 0.15f);
                prr = true;
            }
           
            if (posz == false)
            {
                if (preditora == false && ballobj.transform.position.y>(-4.8f))
                { ballobj.transform.position = new Vector3(0.1f, ballobj.position.y - 0.07f, ballobj.position.z - 0.1f); }
                if (preditora == true)
                {
                    ballobj.transform.position = new Vector3(0.1f, ballobj.position.y, ballobj.position.z - 0.1f);
                    
                }
                ballobj.transform.Rotate(ballobj.rotation.x - rx, ballobj.rotation.y - ry, ballobj.rotation.z - rz);
                if (gozi >= 150)
                {
                    posz = true;
                }
            }

            if (gozi >= 120)
            {
                if (gozi >= 185)
                {
                    SceneManager.LoadScene("GameOver");
                }

                if(gozi>=204)
                {ballobj.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX; }


            }
           

        }
       

            

        





    }
    
    private void OnCollisionEnter(Collision collisioneditoronly)
    {
        if(collisioneditoronly.gameObject.tag=="EditorOnly")
        {
            preditora = true;
        }
    }
    private void OnCollisionExit(Collision collisionexiteditor)
    {
        if (collisionexiteditor.gameObject.tag == "EditorOnly")
        {
            if (DetectCollision.prcolis == false && edit == false)
            {
                preditora = false;
            }
            if(DetectCollision.prcolis== true)
            {
                
                edit = true;
            }
            preditora = false;

        }
    }



}
