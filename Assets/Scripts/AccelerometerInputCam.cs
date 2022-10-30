using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AccelerometerInputCam : MonoBehaviour
{
    public static bool izova;
    public bool prhgscora;
    public SphereCollider sph1;
    public CapsuleCollider cps1;
    public bool prtima;
    public float brpos;
    public Color colo;
    public Rigidbody loptas;
    public int w88;
    public Vector3 v3;
    public bool isgrnd;
    public CharacterController lopta;
    public Light lit;
    public float zatstart = 0;
    public float xatstart = 0;
    public Text axis;
    //public Text axi1s;
    public Text gyaxis;
    public int brgold = 0;
    public bool prcalibrate = false;
    public float hzMovement = 0, vtMovement = 0;
    public Collider ball;
    public SphereCollider goldbal;
    public SphereCollider playr;
    public float poszz;
    public Text plus101;
    //public Text plus102;
    public static bool udarlopte;
    public bool pomudarl;
    public int brojacudara;
    public float tim;
    public Text tim1;
    //public Text tim2;
    public float highsc;
    public float currsc;
    public static float hgh;
    public Vector3 moveDirection;
    public bool udarprvr;
    public bool novabool;
    void Start()
    {
        izova = false;
        brpos = 0;
        novabool = false;
        udarprvr = false;
        prhgscora = false;
        prtima = false;
        Physics.IgnoreCollision(sph1, cps1);
        Physics.IgnoreCollision(sph1, lopta);
        Physics.IgnoreCollision(cps1, lopta);
        moveDirection = new Vector3(0, 0, 0);
        currsc = 0;
        PlayerPrefs.SetFloat("currsc", currsc);
        PlayerPrefs.Save();
        highsc = PlayerPrefs.GetFloat("highsc", highsc);
        currsc = PlayerPrefs.GetFloat("currsc", currsc);
        if (highsc == null)
        {
            highsc = 0;
        }
        hgh = highsc;
        tim1.enabled = true;
        //tim2.enabled = true;
        tim = 0.7f;
        calib();
        brgold = 0;
        prcalibrate = false;
        w88 = 0;
        goldbal = GameObject.FindWithTag("Respawn").GetComponent<SphereCollider>();
        playr= GameObject.FindWithTag("Player").GetComponent<SphereCollider>();
        
        plus101.enabled = false;
        //plus102.enabled = false;
        udarlopte = false;
        brojacudara = 0;
        pomudarl=false;
        //#FF5252FF - Score Text Color
        Color colo = new Color();
        ColorUtility.TryParseHtmlString("#FF5252FF", out colo);
        
        //axi1s.color = colo;
        axis.color = colo;
    }
    void Update()
    {
        if (DetectCollision.prcolis == true)
        {
            
            axis.text = "" + poszz;
            //axi1s.text = "" + poszz;
            //axi1s.fontSize = 80;
            axis.fontSize = 60;
            udarprvr = false;
            udarlopte = false;
            pomudarl = false;
            novabool = true;
        }
        //PlayerPrefs.SetFloat("highsc", 0);
        //PlayerPrefs.Save();
        Physics.IgnoreCollision(sph1, cps1);
        Physics.IgnoreCollision(sph1, lopta);
        Physics.IgnoreCollision(cps1, lopta);

        tim -= 0.01f;
        if(tim>=0)
        {
            if (DetectCollision.prcolis == false && prtima == false)
            {
                if (udarprvr == false) { 
                tim1.text = "" + Mathf.Round((tim * 10));
                //tim2.text = "" + Mathf.Round((tim * 10));
                }
                
                tim1.fontSize = 50;
                //tim2.fontSize = 50;
                //#53B0A5FF
                Color colo = new Color();
                ColorUtility.TryParseHtmlString("#53B0A5FF", out colo);
                tim1.color = colo;
                //tim2.color = colo;

            }
            if (prtima == true)
            {
                tim1.text = "";
                //tim2.text = "";
                tim1.enabled = false;
                //tim2.enabled = false;
            }
            if (DetectCollision.prcolis == true)
            {
                prtima = true;
                tim1.text = "";
                //tim2.text = "";
                tim1.enabled = false;
                //tim2.enabled = false;
            }
            
        }
        if(tim<0 && tim>-0.5)
        {
            if(DetectCollision.prcolis==false && prtima==false)
            {
                tim1.text = "PLAY!";
                //tim2.text = "PLAY!";
                tim1.fontSize = 50;
                //tim2.fontSize = 50;
                //#53B0A5FF
                Color colo = new Color();
                ColorUtility.TryParseHtmlString("#53B0A5FF", out colo);
                tim1.color = colo;
                //tim2.color = colo;
            }
            if(prtima==true)
            {
                tim1.text = "";
                //tim2.text = "";
                tim1.enabled = false;
                //tim2.enabled = false;
            }
            if (DetectCollision.prcolis == true)
            {
                prtima = true;
                tim1.text = "";
                //tim2.text = "";
                tim1.enabled = false;
                //tim2.enabled = false;
            }


        }
        if(tim<=-0.5)
        {
            if(DetectCollision.prcolis==false)
            { 
            tim1.enabled = false;
            //tim2.enabled = false;
            }
            if(DetectCollision.prcolis==true && prhgscora==true)
            { 
            tim1.text = "NEW HIGH SCORE";
            //tim2.text = "NEW HIGH SCORE";
                tim1.enabled = true;
                //tim2.enabled = true;
                tim1.fontSize = 40;
                //tim2.fontSize = 40;
                //#35CDFFFF
                //#99FF80FF ||
                Color colo = new Color();
                ColorUtility.TryParseHtmlString("#99FF80FF", out colo);
                tim1.color = colo;
                //tim2.color = colo;
                //axi1s.color = colo;
                axis.color = colo;
                //You did not pass the score
            }
            if (DetectCollision.prcolis == true && prhgscora == false)
            {
                tim1.text = "";
                //tim2.text = "";
                tim1.enabled = true;
                //tim2.enabled = true;
                tim1.fontSize = 30;
                //tim2.fontSize = 30;
                //#FF0000FF
                Color colo = new Color();
                ColorUtility.TryParseHtmlString("#FF0000FF", out colo);
                tim1.color = colo;
                //tim2.color = colo;
                //axi1s.color = colo;
                axis.color = colo;
                
                //You did not pass the score
            }
        }
       
        //axi1s.transform.position=new Vector3(axi1s.transform.position.x,Screen.height / 5 * 4.4f,0);
        axis.transform.position = new Vector3(axis.transform.position.x, Screen.height / 5 * 4.4f, 0);
        plus101.transform.position = new Vector3(plus101.transform.position.x, Screen.height / 5 * 3.5f, 0);
        //plus102.transform.position = new Vector3(plus102.transform.position.x, Screen.height / 5 * 3.5f, 0);
        if (udarlopte == false)
        {
            plus101.enabled = false;
            //plus102.enabled = false;
        }
        if(udarlopte == true)
        {
            brojacudara++;
            if(brojacudara<=40)
            {
                if(novabool == false)
                { udarprvr = true; }
                if(novabool == true)
                { udarprvr = false; }


                // axis.text = "GOOD JOB!";
                //axi1s.text = "GOOD JOB!";
                //#5294FFFF ||
                Color colo = new Color();
                ColorUtility.TryParseHtmlString("#5294FFFF", out colo);
                
                //axi1s.color = colo;
                axis.color = colo;

                axis.fontSize = 40;
                //axi1s.fontSize = 40;
                if (DetectCollision.prcolis == false && prtima == false)
                {
                    plus101.enabled = true;
                    //plus102.enabled = true;
                }
                if (prtima == true)
                {
                    plus101.enabled = false;
                    //plus102.enabled = false;
                }
                if (DetectCollision.prcolis == true)
                {
                    axis.text = "" + poszz;
                    //axi1s.text = "" + poszz;
                    //axi1s.fontSize = 80;
                    axis.fontSize = 60;
                    prtima = true;
                    plus101.enabled = false;
                    //plus102.enabled = false;
                }
                
            }
            
            if (brojacudara>40)
            {
                udarprvr = false;
                //axis.text = "";
                //axi1s.text = "";

                axis.fontSize = 60;
                //axi1s.fontSize = 80;
                //#FF5252FF ||
                Color colo = new Color();
                ColorUtility.TryParseHtmlString("#FF5252FF", out colo);

                //axi1s.color = colo;
                axis.color = colo;

                udarlopte = false;
                pomudarl = false;
                brojacudara = 0;
            }
        }
        if (w88<30)
        {
            calib();
        }
        if(DetectCollision.prcolis==false)
        { 
        poszz = Mathf.Round((ball.transform.position.z+27)/10) + brgold*10;
        }
        w88++;
        if (DetectCollision.prcolis == true)
        {
            udarprvr = false;
            udarlopte = false;
            pomudarl = false;
            novabool = true;
        }
        if (DetectCollision.prcolis == false)
        {
            if (udarprvr == false)
            {
                brpos = poszz;
                axis.text = "" + poszz;
                //axi1s.text = "" + poszz;
                //axi1s.fontSize = 80;
                axis.fontSize = 60;
            }
            if (udarprvr == true)
            {
                axis.text = "GOOD JOB!";
                //axi1s.text = "GOOD JOB!";
            }
            currsc = poszz;
            PlayerPrefs.SetFloat("currsc", currsc);
            PlayerPrefs.Save();
            if (poszz>highsc)
            {
                prhgscora = true;
                highsc = poszz;
                hgh = highsc;
                PlayerPrefs.SetFloat("highsc", highsc);
                PlayerPrefs.Save();
            }
            
        }
        if (DetectCollision.prcolis == true)
        {
            axis.text = "" + poszz;
            //axi1s.text = "" + poszz;
            //axi1s.fontSize = 80;
            axis.fontSize = 60;
            udarprvr = false;
            udarlopte = false;
            pomudarl = false;
            novabool = true;
        }


        hzMovement = Input.acceleration.x - xatstart;
        vtMovement = -Input.acceleration.z + zatstart;
        /*
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, -1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1f,0 , 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1f, 0, 0);
        }
        */

        if (w88>= 70)
        {
            if (DetectCollision.prcolis == false)
            {
                moveDirection = new Vector3(hzMovement*2.1f, vtMovement*2.1f, 0);
                
                lopta.Move(moveDirection);

                
                
            }
            
        }
       

        if (w88 >= 20)
        {
            lit.enabled = true;
        }
        else
        {
            lit.enabled = false;
        }

    }
    void calib()
    {
        xatstart = Input.acceleration.x;
        zatstart = Input.acceleration.z;
    }
    void OnCollisionEnter(Collision goldb)
    {
        if (goldb.collider.tag == "Respawn")
        {
            
            brgold++;
            udarlopte = true;
            izova = true;
            pomudarl = true;
            Destroy(GameObject.FindWithTag("Respawn"));


        }
    }
    
}