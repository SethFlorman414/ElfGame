using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastPickup : MonoBehaviour {

	// Use this for initialization
	public int purpleCrystal = 0;
    public int blueCrystal;
    public int whiteCrystal;
    

	void Start () {
		PlayerPrefs.SetInt ("Crystal", purpleCrystal);
        PlayerPrefs.SetInt("BlueCrystal", blueCrystal);
        PlayerPrefs.SetInt("WhiteCrystal", whiteCrystal);


    }
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit pickup;
		Ray direction = new Ray (Camera.main.transform.position, Camera.main.transform.forward);

		if(Physics.Raycast (direction, out pickup, 4)){

			if (pickup.collider.tag == "PurpleCrystal") {

				
				if (Input.GetKeyDown (KeyCode.E)) {
					

					//increase key amount here

					purpleCrystal += 1;
                    
					PlayerPrefs.SetInt ("Crystal", purpleCrystal);
                   

                    Destroy (pickup.collider.gameObject);

				}

                

			}

		}

        if(pickup.collider.tag == "BlueCrystal")
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                
                blueCrystal += 1;

                PlayerPrefs.SetInt("BlueCrystal", blueCrystal);


                Destroy(pickup.collider.gameObject);

            }

        }

        if (pickup.collider.tag == "WhiteCrystal")
        {

            if (Input.GetKeyDown(KeyCode.E))
            {

                whiteCrystal += 1;

                PlayerPrefs.SetInt("WhiteCrystal", whiteCrystal);


                Destroy(pickup.collider.gameObject);

            }

        }


    }

    public void PlaceCrystals()
    {



    }

}
