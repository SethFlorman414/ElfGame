using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class AI_Controller : MonoBehaviour {

    // Use this for initialization


    [SerializeField] private NavMeshAgent m_NavMashAgent;
    [SerializeField] private GameObject m_Target;


    void Start () {



		
	}
	
	// Update is called once per frame
	void Update () {


        m_NavMashAgent.SetDestination(m_Target.transform.position);

	}
}
