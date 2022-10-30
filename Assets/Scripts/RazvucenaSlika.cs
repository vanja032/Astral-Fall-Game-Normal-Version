using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RazvucenaSlika : MonoBehaviour {
    public Image targ;
    public Image targball;
    public GameObject bulet;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //bulet = GameObject.FindWithTag("Brobst");
        //targ.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
        //targ.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
        if(ShootingObstacle.prmetka==false)
        {
            targ.enabled = false;
            targball.enabled = false;
        }
        if (ShootingObstacle.prmetka == true && ShootingObstacle.prbala==true)
        {
            targ.enabled = true;
            targball.enabled = true;
        }
        else
        {
            targ.enabled = false;
            targball.enabled = false;
        }
    }
}
