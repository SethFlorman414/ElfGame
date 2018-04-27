using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollide : MonoBehaviour {

    // Use this for initialization

    int enemyHealth;

	void Start () {

        //enemyHealth = PlayerPrefs.GetInt("EnemyHealth");

    }
	
	// Update is called once per frame
	void Update () {

        enemyHealth = PlayerPrefs.GetInt("EnemyHealth");


    }


    void OnCollisionEnter(Collision collision)
    {


        if(collision.gameObject.tag == "Enemy")
        {

            Debug.Log("foo2");
            PlayerPrefs.SetInt("EnemyHealth", PlayerPrefs.GetInt("EnemyHealth") - 10);

        }

    }

}
