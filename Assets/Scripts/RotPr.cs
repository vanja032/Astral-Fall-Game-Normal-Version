using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPr : MonoBehaviour
{
    public int brrot;
    public bool pr;
    public int rotatebr;
    public float rtbr;
    // Use this for initialization
    void Start()
    {
        brrot = 0;
        pr = false;
        rotatebr = Random.Range(300, 600);
        rtbr = Random.Range(0.1f, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (pr == false)
        { brrot++; }
        if (brrot > rotatebr)
        {
            pr = true;

        }
        if (pr == false)
        { transform.Rotate(0, 0, rtbr); }

        if (pr == true)
        { brrot--; }
        if (brrot < 0)
        {
            pr = false;

        }
        if (pr == true)
        { transform.Rotate(0, 0, -rtbr); }

    }
}
