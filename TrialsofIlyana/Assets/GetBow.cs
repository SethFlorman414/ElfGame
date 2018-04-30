using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBow : MonoBehaviour {

    // Use this for initialization

    public GameObject sword;
    public GameObject bow;

    public Animator pickingUp;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        PickUpBow();
		
	}


    public void PickUpBow()
    {

        RaycastHit pickup;
        Ray direction = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(direction, out pickup, 2))
        {

            if (pickup.collider.tag == "Bow")
            {

                Debug.Log("Picking it up");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Pressing E");

                    sword.SetActive(false);
                    pickingUp.SetBool("PickUp", true);
                    

                }

            }

        }

    }

    
    public void SwitchWeapons()
    {



    }

}
