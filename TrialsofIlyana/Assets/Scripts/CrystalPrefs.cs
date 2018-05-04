using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalPrefs : MonoBehaviour {

    // Use this for initialization
    int purpleCrystal;
    public float timer;
    public Text text;
    public Text text2;

	void Start () {
        purpleCrystal = PlayerPrefs.GetInt("Crystal");

    }
	
	// Update is called once per frame
	void Update () {

        purpleCrystal = PlayerPrefs.GetInt("Crystal");
        GetComponent<Text>().text = "Purple Crystal: " + purpleCrystal;

        if(PlayerPrefs.GetInt("Crystal") >= 1)
        {
            GetComponent<Text>().text = "Acquired Purple Crystal";


        }

        timer += Time.deltaTime;
        if (timer >= 30.0f && PlayerPrefs.GetInt("Crystal") >= 1)
        {

            text.GetComponent<Text>().enabled = false;
           

        }

        if(timer >= 40.0f)
        {

            text2.GetComponent<Text>().enabled = true;

            text2.GetComponent<Text>().text = "Plant the crystals on the pedestal in the village.";

        }


    }
}
