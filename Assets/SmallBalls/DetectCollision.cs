using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour {
    public int timiz;
    public float pomf;
    public static bool spas;
    public static bool spae;
    public BoxCollider boxc;
    public SphereCollider spherec;
    public CapsuleCollider kam;
    public Rigidbody ballobj;
    public GameObject bals;
    public GameObject preke;
    public GameObject loptice;
    public static bool prcolis;
    public bool posz=false;
    public GameObject mainkam;
    public int gozi = 0;
    // Use this for initialization
    void Start()
    {
        pomf = 0;
        timiz = 0;
        spas = false;
        spae = false;
        bals = GameObject.FindWithTag("Player");
        preke = GameObject.FindWithTag("Finish");
        loptice = (GameObject)Instantiate(Resources.Load("Loptice"));
        gozi = 0;
    }

    void Update()
    {

       // pomf = PlayerPrefs.GetFloat("pizidibizi", pomf);




        if (prcolis == true)
        {
            gozi++;
            if (posz == false)
            { //ballobj.transform.position = new Vector3(0.1f, 0.1f, ballobj.position.z - 0.1f); if(gozi >= 120)posz = true; 
            }
            if (gozi >= 120)
            {
                if (gozi >= 201)
                {
                    //SceneManager.LoadScene("GameOver");
                }
                ballobj.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
                
            }


        }
        if (prcolis == false)
        {
            
        }
/*
        if(spae==true)
        {
            timiz++;
            spas = true;
        }
        if(timiz>30)
        {
            spas = false;
            timiz = 0;
        }
        */
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="Finish")
        {
            /*if(ShootingObstacle.prmetka==true && spae==false)
            {
                PlayerPrefs.SetFloat("pizidibizi", 2);
                PlayerPrefs.Save();
                spae = true;
                
                
                ShootingObstacle.fiki = true;
            }
            else
            { prcolis = true; }
            if(ShootingObstacle.fiki==true)
            {*/
            if(ShootingObstacle.prmetka==false)
            { 
                prcolis = true;
            }
            if (ShootingObstacle.prmetka == true && ShootingObstacle.prbala==false)
            {
                prcolis = true;
            }
            //}



            //Destroy(bals);


        }
    }
    void OnCollisionStay(Collision otherstay)
    {
        if (otherstay.gameObject.tag == "Finish")
        {
            /*if(ShootingObstacle.prmetka==true && spae==false)
            {
                PlayerPrefs.SetFloat("pizidibizi", 2);
                PlayerPrefs.Save();
                spae = true;
                
                
                ShootingObstacle.fiki = true;
            }
            else
            { prcolis = true; }
            if(ShootingObstacle.fiki==true)
            {*/
            if (ShootingObstacle.prmetka == false)
            {
                prcolis = true;
            }
            if (ShootingObstacle.prmetka == true && ShootingObstacle.prbala == false)
            {
                prcolis = true;
            }
            //}



            //Destroy(bals);


        }
    }

}
