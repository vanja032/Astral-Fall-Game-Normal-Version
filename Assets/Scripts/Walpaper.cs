using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Walpaper : MonoBehaviour {
    public RectTransform walp;
    //public RectTransform walp1;
    public Text b1;
    //public Text b2;
    public float hgs;
    // Use this for initialization
    void Start () {
        
        hgs= PlayerPrefs.GetFloat("highsc", hgs);
        if (hgs==null)
        {
            hgs = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
        //walp.sizeDelta = new Vector2(Screen.width, Screen.height);
        //walp.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);

        // walp1.sizeDelta = new Vector2(Screen.width/2, Screen.height);
        //walp1.transform.position = new Vector2(Screen.width / 4, Screen.height / 2);

        //----------------------------------------------------------------------------------
        b1.transform.position = new Vector3(b1.transform.position.x, Screen.height / 5 * 4.22f, 0);
        //b1.transform.position = new Vector2(Screen.width / 2f, b1.transform.position.y);
        // b2.transform.position = new Vector2(Screen.width / 4*2.95f-10, b2.transform.position.y);
        b1.text ="HIGH SCORE "+ hgs;
        //b2.text = "HIGH SCORE " + hgs;
       // b1.fontSize = Screen.width / 20;
        //b2.fontSize = Screen.width / 23;

    }
}
