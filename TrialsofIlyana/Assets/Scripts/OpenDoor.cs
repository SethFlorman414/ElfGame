using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    // Use this for initialization

    public Animator door;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider collide)
    {

        if (collide.gameObject.tag == "Player")
        {

            door.SetBool("Open", true);

        }


    }

}
