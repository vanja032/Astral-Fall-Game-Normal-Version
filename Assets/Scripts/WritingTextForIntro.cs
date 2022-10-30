using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WritingTextForIntro : MonoBehaviour {
    public bool ll;
    public AudioClip aa;
    public Image introimg0;
    public bool gh;
    public float tr;
    //public Image introimg1;
    public Sprite[] sprites = new Sprite[9];
    public int brojacteksta;
    public AudioSource audiom;
    public static bool brzinabool;
    // Use this for initialization
    void Start () {
        ll = false;
        tr = 0;
        gh = false;
        brzinabool = false;
        //introimg0.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
        //introimg0.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
        //introimg1.rectTransform.sizeDelta = new Vector2(Screen.width / 2, Screen.height);
        //introimg1.transform.position = new Vector2(Screen.width / 4, Screen.height / 2);
        brojacteksta = 0;

    }
	
	// Update is called once per frame
	void Update () {
        brojacteksta++;
        if(brojacteksta>=0 && brojacteksta<70)
        {
            introimg0.sprite = sprites[0];
            //introimg1.sprite = sprites[1];
        }
        if (brojacteksta >= 70 && brojacteksta < 210)
        {
            introimg0.sprite = sprites[1];
            //introimg1.sprite = sprites[3];
        }
        if (brojacteksta >= 210 && brojacteksta < 390)
        {
            introimg0.sprite = sprites[2];
            //introimg1.sprite = sprites[5];
        }
        if (brojacteksta >= 390 && brojacteksta < 540)
        {
            introimg0.sprite = sprites[3];
            //introimg1.sprite = sprites[7];
        }
        if (brojacteksta >= 540 && brojacteksta < 600)
        {
            introimg0.sprite = sprites[4];
            //introimg1.sprite = sprites[9];
        }
        if (brojacteksta >= 600 && brojacteksta < 670)
        {
            introimg0.sprite = sprites[5];
            //introimg1.sprite = sprites[11];
        }
        if (brojacteksta >= 670 && brojacteksta < 740)
        {
            introimg0.sprite = sprites[6];
            //introimg1.sprite = sprites[13];
        }
        if (brojacteksta >= 740 && brojacteksta < 780)
        {
            introimg0.sprite = sprites[7];
            //introimg1.sprite = sprites[15];
        }
        if (brojacteksta >= 780 && brojacteksta <= 830)
        {
            introimg0.sprite = sprites[8];
            //introimg1.sprite = sprites[17];
        }
        if (brojacteksta > 830)
        {
            introimg0.enabled = false;
            //introimg1.enabled = false;
            brzinabool = true;
        }
        if (brojacteksta > 950)
        {
            // SceneManager.LoadScene("Start");
            //audiom.Stop();
            //SceneManager.LoadScene("Start");
            //introimg0.enabled = false;
            //introimg1.enabled = false;

        }
        if (brojacteksta > 960)
        {
            // SceneManager.LoadScene("Start");
            //audiom.Stop();
            //SceneManager.LoadScene("Start");
            introimg0.enabled = false;
            //introimg1.enabled = false;
            brzinabool = true;
        }
        if (brojacteksta > 55)
        {
            if (Input.GetMouseButtonDown(0))
            {
                gh = true;
                //introimg0.enabled = false;
                //introimg1.enabled = false;
                brzinabool = true;
                //tr = brojacteksta + 145;
            }
        }
        if (gh == true)
        {
            if (brojacteksta > tr)
            {
                // SceneManager.LoadScene("Start");
                //audiom.Stop();
                //SceneManager.LoadScene("Start");
                introimg0.enabled = false;
                //introimg1.enabled = false;
                //introimg1.enabled = false;
                brzinabool = true;
            }
        }
        if (DetektujNaStartuKolizijuSaDaskom.pr == true && ll == false)
        {
            audiom.Stop();
            audiom.PlayOneShot(aa);
            ll = true;
        }

    }
}
