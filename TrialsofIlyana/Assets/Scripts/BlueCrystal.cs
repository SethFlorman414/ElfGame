using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueCrystal : MonoBehaviour {

    // Use this for initialization

    int blueCrystal;
    void Start () {
        blueCrystal = PlayerPrefs.GetInt("Crystal");
    }
	
	// Update is called once per frame
	void Update () {

        blueCrystal = PlayerPrefs.GetInt("BlueCrystal");
        GetComponent<Text>().text = "Purple Crystal: " + blueCrystal;

    }
}
