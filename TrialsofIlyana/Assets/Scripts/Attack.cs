using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    // Use this for initialization

    public Animator attack;

    
    public int playerHealth;
    public int gold;
    public int swordDamage;

  

	void Start () {

        PlayerPrefs.SetInt("Health", playerHealth);
        PlayerPrefs.SetInt("Gold", gold);
     

    }
	
	// Update is called once per frame
	void Update () {

        DoingAttacks();


		
	}


    public void DoingAttacks()
    {

        if (Input.GetButton("Fire1"))
        {

            attack.SetBool("Slash", true);
            attack.SetBool("LongSlash", false);

        } else if (!Input.GetButton("Fire1"))
        {

            attack.SetBool("Slash", false);

        }
        

        if (Input.GetButton("Fire2"))
        {

            attack.SetBool("LongSlash", true);
            attack.SetBool("Slash", false);

        } else if (!Input.GetButton("Fire2"))
        {

            attack.SetBool("LongSlash", false);

        }
        

    }

    
}
