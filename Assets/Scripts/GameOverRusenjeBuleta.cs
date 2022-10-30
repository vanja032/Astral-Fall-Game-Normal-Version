using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverRusenjeBuleta : MonoBehaviour {
    public bool prprcolisa;
    public bool pizi;
    public GameObject loptaslomljena;
    public float xl, yl, zl;
    // Use this for initialization
    void Start () {
        pizi = false;
        xl = 0; yl = 0; zl = 0;
        prprcolisa = false;
        loptaslomljena = (GameObject)Instantiate(Resources.Load("LoptaSlomljena"));
    }
	
	// Update is called once per frame
	void Update () {
		if(DetectCollision.prcolis==true && ShootingObstacle.prmetka==true && pizi==false)
        {
            prprcolisa = true;
        }
        if(prprcolisa==true)
        {
            xl = this.gameObject.transform.position.x;
            yl = this.gameObject.transform.position.y;
            zl = this.gameObject.transform.position.z;
            Instantiate(loptaslomljena, new Vector3(xl, yl, zl), Quaternion.identity);
            Destroy(this.gameObject);
            prprcolisa = false;
            pizi = true;
        }
	}
}
