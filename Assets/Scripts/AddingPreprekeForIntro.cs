using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingPreprekeForIntro : MonoBehaviour {

    public GameObject prepreka;
    public GameObject vprepreka;
    //public GameObject goldballs;

    public float rc;
    public float gc;
    public float bc;
    public bool kk;
    public bool proz = false;
    public int brrot;
    public bool pr;
    public int rotatebr;
    public float rtbr;

    public bool tr;

    public Color clr;
    public int brboja;
    public Material mat;
    public int w78=0;
    public float zpos=25;
    public float zposforgoldballs = 25;
    public float zposforball=0;
    public Collider ball;
    public bool prrotate;
    public Vector3 newv3;
	// Use this for initialization
	void Start () {
        kk = false;
		prepreka=(GameObject)Instantiate(Resources.Load("Prepreka"));
        
        vprepreka =(GameObject)Instantiate(Resources.Load("Valjak"));
        //goldballs= (GameObject)Instantiate(Resources.Load("GoldBalls"));
        brrot = 0;
        pr = false;
        brboja = 0;
        rotatebr = Random.Range(300, 600);
        rtbr = Random.Range(0.0001f, 0.0008f);
        Color clr = new Color();
        ColorUtility.TryParseHtmlString("#FFFFFF", out clr);
    }
	
	// Update is called once per frame
	void Update () {
        if(WritingTextForIntro.brzinabool==false)
        {
            zpos = ball.transform.position.z + 200;
        }
        w78++;
        if(ball.transform.position.z >= zpos - 200 && WritingTextForIntro.brzinabool == true)
        {
            prepreka.gameObject.transform.localScale = new Vector3(Random.Range(1.7f, 4f), Random.Range(8.5f, 12.5f), Random.Range(0.2f, 1.0f));

            Instantiate(prepreka, new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(-3.5f, 3.5f), Random.Range(zpos - 1.0f, zpos + 1.0f)), Quaternion.identity);
            if (ball.transform.position.z<=490)
            { zpos = zpos + 38; }
            if (ball.transform.position.z >= 490 && ball.transform.position.z < 990)
            { zpos = zpos + 37; }
            if (ball.transform.position.z >= 990 && ball.transform.position.z < 1190)
            { zpos = zpos + 36; }
            if (ball.transform.position.z >= 1190 && ball.transform.position.z < 1390)
            { zpos = zpos + 35; }
            if (ball.transform.position.z >= 1390 && ball.transform.position.z < 1590)
            { zpos = zpos + 34; }
            if (ball.transform.position.z >= 1590 && ball.transform.position.z < 1790)
            { zpos = zpos + 33; }
            if (ball.transform.position.z >= 1790 && ball.transform.position.z < 1990)
            { zpos = zpos + 32; }
            if (ball.transform.position.z >= 1990 && ball.transform.position.z < 2190)
            { zpos = zpos + 31; }
            if (ball.transform.position.z >= 2190 && ball.transform.position.z < 2390)
            { zpos = zpos + 28; }
            if (ball.transform.position.z >= 2390 && ball.transform.position.z < 2590)
            { zpos = zpos + 27; }
            if (ball.transform.position.z >= 2590 && ball.transform.position.z < 2790)
            { zpos = zpos + 25; }
            if (ball.transform.position.z >= 2790 && ball.transform.position.z < 3090)
            { zpos = zpos + 24; }
            if (ball.transform.position.z >= 3090 && ball.transform.position.z < 3290)
            { zpos = zpos + 22; }
            if (ball.transform.position.z >= 3290 && ball.transform.position.z < 3750)
            { zpos = zpos + 21; }
            if (ball.transform.position.z >= 3750)
            { zpos = zpos + 18; }






            w78 = 0;
        }
        



        if (ball.transform.position.z>=zposforball-450)
        {



            //if (WritingTextForIntro.brzinabool == false)
            //{
                Instantiate(vprepreka, new Vector3(3.46f, 4.13f, zposforball + 67f), Quaternion.identity);
            //}
            if(WritingTextForIntro.brzinabool==true && kk==false)
            {
                //prepreka.gameObject.transform.localScale = new Vector3(20, 20, 5);
                
                //GameObject pl = Instantiate(prepreka, new Vector3(0, 0, zposforball + 34.3f), Quaternion.identity);
                //pl.transform.eulerAngles = new Vector3(-Random.Range(-45,45), Random.Range(-55,55), 0);
                kk = true;
            }
            zposforball = zposforball +67f;
            brboja++;
            if (brboja < 10)
            {
                rc = 255;
                bc = 204;
                gc = 204;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#FFFFFF", out clr);

                mat.color = clr;
            }
            if (brboja == 10)
            {
                rc = 255;
                bc = 204;
                gc = 204;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#FF9999", out clr);
                
                mat.color = clr;
            }
            if (brboja == 12)
            {
                rc = 255;
                bc = 153;
                gc = 153;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#FFFF33", out clr);
                mat.color = clr;
            }
            if (brboja == 14)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#99FF33", out clr);
                mat.color = clr;
            }
            if (brboja == 16)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#3399FF", out clr);
                mat.color = clr;
            }
            if (brboja == 18)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#B266FF", out clr);
                mat.color = clr;
            }
            if (brboja == 20)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#00CCCC", out clr);
                mat.color = clr;
            }
            if (brboja == 22)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#00994C", out clr);
                mat.color = clr; 
            }
            if (brboja == 24)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#99FF99", out clr);
                mat.color = clr;
            }
            if (brboja == 26)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#FFFF66", out clr);
                mat.color = clr;
            }
            if (brboja == 28)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#009999", out clr);
                mat.color = clr;
            }
            if (brboja == 30)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#FFFF33", out clr);
                mat.color = clr;
            }
            if (brboja == 32)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#FF66FF", out clr);
                mat.color = clr;
            }
            if (brboja == 34)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#F37EFC", out clr);
                mat.color = clr;
            }
            if (brboja == 36)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#64C074", out clr);
                mat.color = clr;
            }
            if (brboja == 38)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#009B1A", out clr);
                mat.color = clr;
            }
            if (brboja == 40)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#88cc00", out clr);
                mat.color = clr;
            }
            if (brboja == 42)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#00FFFF", out clr);
                mat.color = clr;
            }
            if (brboja == 44)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#FFB266", out clr);
                mat.color = clr;
            }
            if (brboja == 46)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#6C7594", out clr);
                mat.color = clr;
            }
            if (brboja == 48)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#FFEF00", out clr);
                mat.color = clr;
            }
            if (brboja == 50)
            {
                rc = 255;
                bc = 102;
                gc = 102;
                Color clr = new Color();
                ColorUtility.TryParseHtmlString("#5DA64F", out clr);
                mat.color = clr;
                brboja = 7;
            }


        }






        if (ball.transform.position.z >= zposforgoldballs - 200)
        {
            

           // Instantiate(goldballs, new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), Random.Range(zposforgoldballs - 1.0f, zposforgoldballs + 1.0f)), Quaternion.identity);
            zposforgoldballs = zposforgoldballs + Random.Range(90,150); 
            
        }



    }
    
    
}
