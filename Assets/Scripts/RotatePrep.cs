using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePrep : MonoBehaviour {
    public int randd;
    public bool detectudar = false;
    public CapsuleCollider ball;
    public BoxCollider cubes;
    public float pbrot;
    public int br = 0;
    public bool prov = false;
    public int rotatebr;
    // Use this for initialization
    void Start()
    {
        randd = 0;
        ball = FindObjectOfType<CapsuleCollider>();
        rotatebr = Random.Range(500, 1200);
        randd = Random.Range(1, 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        pbrot = ball.transform.position.z / 450;
        if (randd == 1)
        {
            pbrot = pbrot * (-1);
        }
        if (br < 0)
        {
            prov = false;
            rotatebr = Random.Range(500, 1200);
            
            
            
        }
        if (br > rotatebr)
        {
            prov = true;
        }
        if (prov == false)
        { transform.Rotate(new Vector3(0, 0, 1), 14*pbrot * Time.deltaTime); br++; }
        if (prov == true)
        { transform.Rotate(new Vector3(0, 0, 1), 14*pbrot*(-1) * Time.deltaTime); br--; }




    }
   
    
}
