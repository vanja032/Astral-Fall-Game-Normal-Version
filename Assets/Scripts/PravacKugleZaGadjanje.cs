using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PravacKugleZaGadjanje : MonoBehaviour {
    public bool pr;
    public int br;
	// Use this for initialization
	void Start () {
        pr = false;
        br = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(ShootingObstacle.pukni==true)
        {
            br++;
            pr = true;
            ShootingObstacle.pukni = false;
            //ShootingObstacle.Destroy(gameObject.GetComponent<MonoBehaviour>());
    
           
        }
        
        if(pr==true)
        {
            //this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 1f);
            this.gameObject.AddComponent<MovingBullet>();
            pr = false;
            Destroy(this);
        }
	}
}
