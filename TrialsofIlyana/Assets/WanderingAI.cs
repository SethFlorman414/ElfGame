using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderingAI : MonoBehaviour {

    // Use this for initialization


    public float wanderRadius;
    public float wanderTimer;

    private Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    private float timer;

    public Animator elfAnim;


	void OnEnable()
    {

        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        timer = wanderTimer;

    }


	
	// Update is called once per frame
	void Update () {


        timer += Time.deltaTime;

        if(timer >= wanderTimer)
        {

            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            elfAnim.SetBool("isWalking", true);
            timer = 0;

        }


	}

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        UnityEngine.AI.NavMeshHit navHit;

        UnityEngine.AI.NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }

}
