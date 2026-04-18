using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class RobotShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform hand;
    private Quaternion bulletRotation;
    public Transform player;
    private NavMeshAgent agent;
    void Update()
    {
        //if (agent.transform.position = player.position) 
        {
            bulletRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);

            Instantiate(bullet, hand.position, bulletRotation);
        }
    }
}
