using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontaktDaskeUStartuSaLoptom1 : MonoBehaviour {
    public float xd;
    public float yd;
    public float zd;
    public bool pr;
    public GameObject boxes;
    // Use this for initialization
    void Start () {
        pr = false;
        boxes = (GameObject)Instantiate(Resources.Load("CubeBoxes"));
    }
	
	// Update is called once per frame
	void Update () {
        xd = this.gameObject.transform.position.x;
        yd = this.gameObject.transform.position.y;
        zd = this.gameObject.transform.position.z;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EditorOnly" || collision.gameObject.tag == "Finish")
        {
            pr = true;
            Instantiate(boxes, new Vector3(xd, yd, zd), Quaternion.identity);
            Instantiate(boxes, new Vector3(xd, yd, zd), Quaternion.identity);
            Destroy(this.gameObject);
        }
        
    }
    
}
