using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokeBall : MonoBehaviour {
    
    public GameObject ball;
    public GameObject boxes;
    public GameObject MainCam;
    public bool pr;
	// Use this for initialization
	void Start () {
        boxes = (GameObject)Instantiate(Resources.Load("CubeBoxes"));
        pr = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (DetectCollision.prcolis == true)
        {
           // Destroy(ball);
            if (pr == false)
            {
                Instantiate(boxes, new Vector3(MainCam.transform.position.x, MainCam.transform.position.y, MainCam.transform.position.z-0.5f), Quaternion.identity);
                Instantiate(boxes, new Vector3(MainCam.transform.position.x, MainCam.transform.position.y, MainCam.transform.position.z- 0.6f), Quaternion.identity);
                pr = true;
            }
        }
        }
}
