using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static EnemyTrigger;

public class SimpleAI : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    public void StartChase()
    {
        // goes after the player
        agent.SetDestination(target.position);
    }
    void Update()
    {
        // checks if the enemy should start chasing the player
        if (TriggerEnemy == true)
        {
            StartChase();
        }
    }
}
