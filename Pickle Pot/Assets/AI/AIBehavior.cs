using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
    private bool canPatrol = true;
    private int i = 0;

    public List<Transform> patrolPoints;
    
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        canPatrol = false;
        destination = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        canPatrol = true;
    }

    private Transform Patrol()
    {
        return transform;
    }
    private void Update()
    {
        agent.destination = destination.position;
        if (!canPatrol) return;
        
       
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            destination = patrolPoints[i];
            i = (i + 1) % patrolPoints.Count;
        }
    }
}
