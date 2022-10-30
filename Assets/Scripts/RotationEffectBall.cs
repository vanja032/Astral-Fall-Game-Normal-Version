using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationEffectBall : MonoBehaviour {

    public bool trzz = false;
    public float brzz = 2;
    public Collider ball;
    public float fx;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        
        if (brzz < ball.transform.position.z / 5)
        {
            trzz = true;
        }
        if (trzz == true)
        {
            brzz = 2 + ball.transform.position.z / 500;
        }
        transform.Rotate(new Vector3(ball.transform.position.z/5+20, 0, 0), brzz *60 * Time.deltaTime);

    }
}
