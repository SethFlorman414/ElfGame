using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHealth : MonoBehaviour {

    // Use this for initialization

    int playerHealth;

	void Start () {

        playerHealth = PlayerPrefs.GetInt("Health");

	}
	
	// Update is called once per frame
	void Update () {
		
        playerHealth = PlayerPrefs.GetInt("Health");
        GetComponent<Text>().text = "Health: " + playerHealth;

    }
}
