using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteCrystal : MonoBehaviour {

    // Use this for initialization

    int whiteCrystal;
    public float timer;
    public Text text;

    void Start () {

        whiteCrystal = PlayerPrefs.GetInt("WhiteCrystal");

    }
	
	// Update is called once per frame
	void Update () {

        whiteCrystal = PlayerPrefs.GetInt("WhiteCrystal");
        GetComponent<Text>().text = "White Crystal: " + whiteCrystal;

        if (PlayerPrefs.GetInt("WhiteCrystal") >= 1)
        {
            GetComponent<Text>().text = "Acquired White Crystal";


        }

        timer += Time.deltaTime;
        if (timer >= 30.0f && PlayerPrefs.GetInt("WhiteCrystal") >= 1)
        {

            text.GetComponent<Text>().enabled = false;
            timer = 0;

        }

    }
}
