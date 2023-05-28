using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static EnemyTrigger;

public class SimpleAI : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    private bool triggered;

    void Start()
    {
        triggered = false;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    public void StartChase()
    {
        // goes after the player
        agent.SetDestination(target.position);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        triggered = true;
    }
    void Update()
    {
        if (triggered == true)
        {
            StartChase();
        }
    }
}
