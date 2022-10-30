using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Walpaper1 : MonoBehaviour {
    public RectTransform walp1;
    //public RectTransform walp11;
    public Text b11;
    //public Text b21;
    public Text b31;
    //public Text b41;
    public float hgss; public float currscc;
    // Use this for initialization
    void Start () {
        currscc = PlayerPrefs.GetFloat("currsc", currscc);
        hgss = PlayerPrefs.GetFloat("highsc", hgss);
        if (hgss == null)
        {
            hgss = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
        // walp1.sizeDelta = new Vector2(Screen.width, Screen.height);
        //walp1.transform.position = new Vector2(Screen.width /2, Screen.height / 2);

        //walp11.sizeDelta = new Vector2(Screen.width/2, Screen.height);
        //walp11.transform.position = new Vector2(Screen.width / 4, Screen.height / 2);

        //----------------------------------------------------------------------------------
        b11.transform.position = new Vector3(b11.transform.position.x, Screen.height / 5 * 4.22f, 0);
        b31.transform.position = new Vector3(b31.transform.position.x, Screen.height / 5 * 4.22f-90, 0);
        //b11.transform.position = new Vector2(Screen.width /2.1f, b11.transform.position.y);
        //b21.transform.position = new Vector2(Screen.width / 4*2.95f-10, b21.transform.position.y);
        //b31.transform.position = new Vector2(Screen.width /2.1f, b31.transform.position.y);
        //b41.transform.position = new Vector2(Screen.width / 4 * 2.95f - 10, b41.transform.position.y);
        b11.text = "HIGH SCORE " + hgss;
        //b21.text = "HIGH SCORE " + hgss;
        b31.text = "SCORE " + currscc;
        //b41.text = "SCORE " + currscc;
       // b11.fontSize = Screen.width / 21;
        //b21.fontSize = Screen.width / 23;
        //b31.fontSize = Screen.width / 21;
        //b41.fontSize = Screen.width / 23;
        DetectCollision.prcolis = false;
        PlayerPrefs.SetFloat("currsc", 0);
        PlayerPrefs.Save();
    }
}
