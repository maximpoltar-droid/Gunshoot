using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (SafeZone.go == true)
        {
            agent.SetDestination(player.position);
            
        }
        if (SafeZone.go == false)
        {
            
            agent.SetDestination(new Vector3 (transform.position.x - 250,transform.position.y,transform.position.z));
            SafeZone.go = true;
        }
    }
}
