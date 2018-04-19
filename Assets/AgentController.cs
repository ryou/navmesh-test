using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour {

    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        this.agent = GetComponent<NavMeshAgent>();
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        this.animator.SetFloat("Speed", this.agent.velocity.sqrMagnitude);

        if (Input.GetMouseButtonDown(0))
        {
            Ray();
        }
    }

    void Ray()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10.0f))
        {
            this.agent.SetDestination(hit.point);
        }
    }

    public void OnCallChangeFace()
    {

    }
}
