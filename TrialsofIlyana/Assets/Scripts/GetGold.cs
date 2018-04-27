using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetGold : MonoBehaviour {

    // Use this for initialization

    int gold;

	void Start () {

        gold = PlayerPrefs.GetInt("Gold");

    }
	
	// Update is called once per frame
	void Update () {

        gold = PlayerPrefs.GetInt("Gold");
        GetComponent<Text>().text = "Gold: " + gold;


    }
}
