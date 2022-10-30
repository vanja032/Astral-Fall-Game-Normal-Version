using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlomiDask : MonoBehaviour {
    public bool dasek;
    public static bool dasek1;

    public float xd;
    public float yd;
    public float zd;

    public float xl;
    public float yl;
    public float zl;

    public GameObject daskaslomljena;
    public GameObject loptaslomljena;
    // Use this for initialization
    void Start () {
        dasek = false;
        dasek1 = false;
        daskaslomljena = (GameObject)Instantiate(Resources.Load("BrokenObstacle 1"));
        loptaslomljena = (GameObject)Instantiate(Resources.Load("LoptaSlomljena"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision cibuki)
    {
        dasek = true;
        
        if (cibuki.gameObject.tag== "Brobst")
        {
            dasek1 = true;
            if(ShootingObstacle.prmetka==false)
            {
                ShootingObstacle.prbroja = false;
                ShootingObstacle.broj = 0;
            }
            xl = GameObject.FindWithTag("Brobst").transform.position.x;
            yl = GameObject.FindWithTag("Brobst").transform.position.y;
            zl = GameObject.FindWithTag("Brobst").transform.position.z;

            xd = this.gameObject.transform.position.x;
            yd = this.gameObject.transform.position.y;
            zd = this.gameObject.transform.position.z;
            Instantiate(daskaslomljena, new Vector3(xd, yd, zd), Quaternion.identity);
            Instantiate(loptaslomljena, new Vector3(xl, yl, zl), Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(GameObject.FindWithTag("Brobst"));
            //Destroy(this);

        }
    }
}
