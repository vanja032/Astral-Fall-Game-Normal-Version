using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZidDetect : MonoBehaviour {
    public static bool przida;
    public bool zidpr;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnCollisionEnter(Collision zid)
    {
        if (zid.gameObject.tag == "EditorOnly")
        {
            przida = true;
            zidpr = true;
        }
        
    }
    private void OnCollisionExit(Collision ex)
    {
        if (ex.gameObject.tag == "EditorOnly")
        {
            przida = false;
            zidpr = false;



        }
        
    }
}
