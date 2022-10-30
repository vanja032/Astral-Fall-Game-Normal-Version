using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisionCopy : MonoBehaviour {

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
        bals = GameObject.FindWithTag("Player");
        preke = GameObject.FindWithTag("Finish");
        loptice = (GameObject)Instantiate(Resources.Load("Loptice"));
        gozi = 0;
    }

    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        posz = true;
        if (other.gameObject.tag=="Finish")
        {
            prcolis = true;
            posz = true;
            Destroy(GameObject.FindWithTag("Finish"));
            Destroy(GameObject.FindWithTag("Brobst"));
            //Destroy(bals);


        }
    }
    
}
