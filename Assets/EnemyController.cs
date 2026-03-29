using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private bool stateAvoidDanger = false;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (stateAvoidDanger == false)
        { 
            agent.SetDestination(player.position);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger1"))
        {
            StartCoroutine(WaitAndPrint());
            stateAvoidDanger = true;
            Debug.Log("Robot has enter to the water");
            agent.SetDestination(new Vector3(transform.position.x - 15, transform.position.y, transform.position.z -15));
            IEnumerator WaitAndPrint()
            {
                // Ждём 2 секунды
                yield return new WaitForSeconds(1f);

                // Выполняем действие после задержки
                Debug.Log("Прошла 1 секунда!");
                stateAvoidDanger = false;
            }
        }
    }
}
