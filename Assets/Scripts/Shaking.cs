using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shaking : MonoBehaviour {
    public bool pro;
    public bool pro1;
    // Use this for initialization
    void Start () {
        pro = false;
        pro1 = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (ShowAdMobRewardedVideo.interload1 == true || ShowAdMobRewardedVideo.videoload1 == true)
        {
            if (ShowAdMobRewardedVideo.interload == false || ShowAdMobRewardedVideo.videoload == false)
            {
                pro = true;
                if (Input.acceleration.sqrMagnitude >= 2f)
                {
                    SceneManager.LoadScene("RolingOnTheRain");
                }
            }
        }
        else
        {
            pro1 = true;
            if (Input.acceleration.sqrMagnitude >= 2f)
            {
                SceneManager.LoadScene("RolingOnTheRain");
            }
        }
	}
}
