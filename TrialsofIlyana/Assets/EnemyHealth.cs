using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    // Use this for initialization

        

    public int enemyHealth = 0;

    

	void Start () {

        //PlayerPrefs.SetInt("EnemyHealth", enemyHealth);
		
	}
	
	// Update is called once per frame
	void Update () {

        enemyHealth = PlayerPrefs.GetInt("EnemyHealth", enemyHealth);

        if (enemyHealth <= 0)
        {

            Destroy(gameObject);

        }

    }

   
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.collider.gameObject.tag == "Sword")
        {
            
            PlayerPrefs.SetInt("EnemyHealth", PlayerPrefs.GetInt("EnemyHealth") - 1);
           


        }
        

    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("foo");
    }

    }
