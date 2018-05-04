using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueCrystal : MonoBehaviour {

    // Use this for initialization

    int blueCrystal;
    public float timer;
    public Text text;

    void Start () {
        blueCrystal = PlayerPrefs.GetInt("Crystal");
    }
	
	// Update is called once per frame
	void Update () {

        blueCrystal = PlayerPrefs.GetInt("BlueCrystal");
        GetComponent<Text>().text = "Blue Crystal: " + blueCrystal;

        if (PlayerPrefs.GetInt("BlueCrystal") >= 1)
        {
            GetComponent<Text>().text = "Acquired Blue Crystal";


        }

        timer += Time.deltaTime;
        if(timer >= 30.0f && PlayerPrefs.GetInt("BlueCrystal") >= 1)
        {

            text.GetComponent<Text>().enabled = false;
            timer = 0;

        }

    }
}
