using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteCrystal : MonoBehaviour {

    // Use this for initialization

    int whiteCrystal;
    void Start () {

        whiteCrystal = PlayerPrefs.GetInt("WhiteCrystal");

    }
	
	// Update is called once per frame
	void Update () {

        whiteCrystal = PlayerPrefs.GetInt("WhiteCrystal");
        GetComponent<Text>().text = "Purple Crystal: " + whiteCrystal;

    }
}
