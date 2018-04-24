using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class AI_Controller : MonoBehaviour {

    // Use this for initialization

    [Header("NavMesh Settings / Target")]
    [SerializeField] private NavMeshAgent m_NavMashAgent;
    [SerializeField] private GameObject m_Target;

    [Header("Animation Settings")]
    [SerializeField] private Animator m_Animator;
    [SerializeField] private CurrentState m_CurrentState;

    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {


        //m_NavMashAgent.SetDestination(m_Target.transform.position);
        AnimationChecker();

	}

    private void AnimationChecker()
    {
        if(m_CurrentState == CurrentState.Idle)
        {

            m_Animator.SetBool("isWalking", false);
            m_Animator.SetBool("isRunning", false);

        }
        else if (m_CurrentState == CurrentState.Walking)
        {

            m_Animator.SetBool("isWalking", true);
            m_Animator.SetBool("isRunning", false);

        }
        else if (m_CurrentState == CurrentState.Running)
        {

            m_Animator.SetBool("isWalking", false);
            m_Animator.SetBool("isRunning", true);

        }

        

    }

    IEnumerator TestSwitch()
    {

        yield return new WaitForSeconds(2);
        m_CurrentState = CurrentState.Running;

    }

    enum CurrentState
    {

        Idle,
        Walking,
        Running

    }
}
