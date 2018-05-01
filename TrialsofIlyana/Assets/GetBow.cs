using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBow : MonoBehaviour {

    // Use this for initialization

    public GameObject sword;
    public GameObject bow;

    public int arrows;

    public Animator weapon;

    public GameObject arrowPrefab;
    public Camera fpsCam;

    public float range = 100f;
    public float bulletSpeed = 10.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    private float timer;

    void Start () {

        PlayerPrefs.SetInt("Arrows", arrows);
		
	}
	
	// Update is called once per frame
	void Update () {

        SwitchWeapons();
        ShootArrow();
        ReloadBow();
		
	}


    
    public void ReloadBow()
    {

        if (Input.GetKey(KeyCode.R))
        {

            weapon.SetBool("ShootArrow", true);

        }
        else
        {

            weapon.SetBool("ShootArrow", false);

        }

    }

    
    public void SwitchWeapons()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            sword.SetActive(true);
            weapon.SetBool("SwitchSword", true);
            weapon.SetBool("SwitchBow", false);
            bow.SetActive(false);

        } else if (Input.GetKey(KeyCode.Alpha2))
        {

            sword.SetActive(false);
            bow.SetActive(true);
            weapon.SetBool("SwitchBow", true);
            weapon.SetBool("SwitchSword", false);

        }

        
    }


    public void ShootArrow()
    {

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            timer += Time.deltaTime;
            if (Input.GetButtonDown("Fire1") && timer >= shootDelay)
            {
                //get the mouse position
                //var mousePosition = Input.mousePosition;
                //convert the mouse position from pixels to x,y values in the game
                Vector3 camForward = fpsCam.transform.forward;//.ScreenToWorldPoint(mousePosition);
                //create the shoot direction, which is calculated by mousePosition - playerPosition
                Vector3 shootDirection = camForward;//new Vector3(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y, mousePosition.z - transform.position.z);
                //create the bullet object
                Debug.Log("x = " + shootDirection.x + " y = " + shootDirection.y + " z = " + shootDirection.z);
                //reduce the length of the direction to 1, so it is always the same regardless of how far away
                //the mouse is from the player. 
                shootDirection.Normalize();

                Vector3 spawnPosition = transform.position;
                //spawnPosition.x += shootDirection.x * -0.2f;
                //spawnPosition.y += shootDirection.y * 0.1f;
                //spawnPosition.z += shootDirection.z * 4.0f;

                //create the object in front of the player
                GameObject bullet = Instantiate(arrowPrefab, spawnPosition, Quaternion.identity);
                //apply the velocity in the shoot direction
                bullet.GetComponent<Rigidbody>().velocity = shootDirection * bulletSpeed;
                Destroy(bullet, bulletLifetime);
                timer = 0;

            }


        }

    }
    
}
