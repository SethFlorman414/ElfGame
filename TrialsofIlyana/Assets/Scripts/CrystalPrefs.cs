using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalPrefs : MonoBehaviour {

    // Use this for initialization
    int purpleCrystal;

	void Start () {
        purpleCrystal = PlayerPrefs.GetInt("Crystal");

    }
	
	// Update is called once per frame
	void Update () {

        purpleCrystal = PlayerPrefs.GetInt("Crystal");
        GetComponent<Text>().text = "Purple Crystal: " + purpleCrystal;


    }
}
