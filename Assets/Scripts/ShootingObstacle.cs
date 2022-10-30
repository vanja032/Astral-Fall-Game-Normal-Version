using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingObstacle : MonoBehaviour {
    public GameObject bullet;
    public float puzi;
    public float x1;
    public float y1;
    public float z1;
    public GameObject raspadnutalopta;
    public static bool prmetka;
    public GameObject cameer;
    public static bool pukni;
    public ParticleSystem gas;
    public GameObject partis;
    GameObject ball;
    GameObject pazu;
    //public Material mat;
    public static bool fiki;
    public static bool prbala;
    public static bool prbroja;
    public static int brojpom;
    public static int broj;
    // Use this for initialization
    void Start () {
        x1 = 0;y1 = 0;z1 = 0;
        prbroja = false;
        broj = 0;
        prbala = false;
        puzi = 0;
        fiki = false;
        pukni = false;
        prmetka = false;
        bullet = (GameObject)Instantiate(Resources.Load("SphereForBreakingObstacle"));
        partis = (GameObject)Instantiate(Resources.Load("Particle(1)"));
        raspadnutalopta= (GameObject)Instantiate(Resources.Load("RaspadnutaLopta"));

    }

    // Update is called once per frame
    void Update()
    {
        
        //puzi = PlayerPrefs.GetFloat("pizidibizi", puzi);
        //if(ShootingObstacle.fiki == true)
        //{
            //PlayerPrefs.SetFloat("pizidibizi", 2);
            //PlayerPrefs.Save();
        //}/*
        //if(puzi != 1)
        //{
            //Destroy(this);
        //}*/
        //if (puzi == 1)
        // {
            //if (DetectCollision.spae == true)
            //{
                //ShootingObstacle.fiki = true;
            //}
            //if (ShootingObstacle.fiki == true)
            // {
                /*bullet = null;
                partis = null;
                ball = null;
                pazu = null;*/

                //Destroy(GameObject.FindWithTag("Brobst"));
            //}
            //if(ShootingObstacle.fiki==false)
            //{ 
            if(prbroja==true && prmetka==false)
        {
            broj++;
            brojpom = broj;
        }
            if(broj>=70)
        {
            brojpom = broj;
            x1 = ball.transform.position.x;
            y1 = ball.transform.position.y;
            z1 = ball.transform.position.z;
            Destroy(ball);
            Instantiate(raspadnutalopta, new Vector3(x1, y1, z1), Quaternion.identity);
            prbroja = false;
            prmetka = false;
            broj = 0;
            AccelerometerInputCam.izova = false;
        }
            /*
        if (ball == null && prmetka == false && AccelerometerInputCam.izova==true)
        {
            prbroja = false;
            //prmetka = false;
            broj = 0;
        }
        */
        if (AccelerometerInputCam.izova == true && prmetka == false && prbroja==false)
            {
            //Color clr = new Color();
            //clr.a = 0f;
            //mat.color = clr;
            //mat.color = clr;
            ball = new GameObject();
                ball = Instantiate(bullet, new Vector3(cameer.transform.position.x, cameer.transform.position.y, cameer.transform.position.z), Quaternion.identity);
                ball.transform.SetParent(cameer.transform);
                ball.transform.tag = "Brobst";
                prmetka = true;
            prbroja = true;
            //partiklegas
            //gas = GameObject.FindWithTag("partiklegas").GetComponent<ParticleSystem>();
            //gas.Stop();
            //gas.Clear();
            //AccelerometerInputCam.izova = false;
            AccelerometerInputCam.izova = false;
        }
            if (prmetka == true)
            {
            AccelerometerInputCam.izova = false;
            if (ball == null)
            {
                ShootingObstacle.prbala = false;
            }
            else
            {
                ShootingObstacle.prbala = true;
            }
            //fiki = true;
            //if (ball == null)
            //{
            // if (DetectCollision.spae == true)
            //{
            //   ShootingObstacle.fiki = true;
            // }
            //prmetka = false;
            //}
            if (Input.GetMouseButtonDown(0))
                {
                //fiki = false;
                //gas.Play();
                //Shoot
                AccelerometerInputCam.izova = false;
                pazu = Instantiate(partis, new Vector3(ball.transform.position.x, ball.transform.position.y, ball.transform.position.z), Quaternion.identity);

                    //pazu.gameObject.AddComponent<MovingBullet>();
                    pazu.transform.Rotate(0, 180, 0);
                    pazu.transform.SetParent(ball.transform);
                    ball.gameObject.AddComponent<OdvajanjeOdParenta>();
                    
                    prmetka = false;
                    pukni = true;



                }
            }
            //}//
       // }
    }
}
