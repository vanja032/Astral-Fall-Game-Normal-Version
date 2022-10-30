using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour
{
    public int w8;
    public float zatstart = 0;
    public float xatstart = 0;
    public float hzMovement = 0, vtMovement = 0;
    void Start()
    {
        calib();
    }
    void Update()
    {
        hzMovement = Input.acceleration.x - xatstart;
        vtMovement = -Input.acceleration.z + zatstart;
        w8++;
        if(w8>= 170)
        { transform.Translate(hzMovement/400, vtMovement/400, 0); }
       

    }
    void calib()
    {
        xatstart = Input.acceleration.x;
        zatstart = Input.acceleration.z;
    }
}