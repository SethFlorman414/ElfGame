using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCrystal : MonoBehaviour {

    // Use this for initialization

    public GameObject purple;
    public GameObject blue;
    public GameObject white;

    public GameObject beam;
    public float timer;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit dropoff;
        Ray direction = new Ray(Camera.main.transform.position + Camera.main.transform.forward, Camera.main.transform.forward);

        if (Physics.Raycast(direction, out dropoff, 4))
        {
            
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (dropoff.collider.tag == "Pedestal")
                    {
                        if(PlayerPrefs.GetInt("Crystal") >= 1)
                    {

                        purple.SetActive(true);

                    }

                        if(PlayerPrefs.GetInt("BlueCrystal") >= 1)
                    {

                        blue.SetActive(true);

                    }

                        if(PlayerPrefs.GetInt("WhiteCrystal") >= 1)
                    {

                        white.SetActive(true);

                    }
                    

                    }

                }
            }

        timer += Time.deltaTime;
        if (timer >= 120.0f)
        {

            beam.SetActive(true);

        }

    }
}
