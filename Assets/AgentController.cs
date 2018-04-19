using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour {
    public Transform target;

    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        this.agent = GetComponent<NavMeshAgent>();
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        this.agent.SetDestination(target.position);
        this.animator.SetFloat("Speed", this.agent.velocity.sqrMagnitude);
    }
}
