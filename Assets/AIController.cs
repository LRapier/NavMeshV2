using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent agent;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 2f);
    }

    void UpdateTarget()
    {
        agent.SetDestination(target.transform.position);
    }
}
