using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickup : MonoBehaviour {

    // Use this for initialization
    public int gold;

	void Start () {

        PlayerPrefs.SetInt("Gold", gold);
		
	}
	
	// Update is called once per frame
	void Update () {


        RaycastHit pickup;
        Ray direction = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(direction, out pickup, 4))
        {

            if (pickup.collider.tag == "Gold")
            {

                Debug.Log("Do I have gold?");
                if (Input.GetKeyDown(KeyCode.E))
                {


                    //increase key amount here

                    gold += 1;

                    PlayerPrefs.SetInt("Gold", gold);


                    Destroy(pickup.collider.gameObject);

                }

            }

        }

    }
}
