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
                
                Vector3 camForward = fpsCam.transform.forward;
                Vector3 shootDirection = camForward;
               
                shootDirection.Normalize();

                Vector3 spawnPosition = transform.position;
                

                
                GameObject bullet = Instantiate(arrowPrefab, spawnPosition, Quaternion.identity);
                
                bullet.GetComponent<Rigidbody>().velocity = shootDirection * bulletSpeed;
                Destroy(bullet, bulletLifetime);
                timer = 0;

            }


        }

    }
    
}
