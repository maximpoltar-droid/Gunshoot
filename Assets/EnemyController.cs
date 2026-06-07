using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private bool canShoot = false;
    private bool stateAvoidDanger = false;
    public GameObject bullet;
    public Transform hand;
    private Quaternion bulletRotation;
    private float bulletTimer = 1f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {

        if (canShoot == true && bulletTimer ==1f)
        {
            bulletTimer -= Time.deltaTime;
            bulletRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - 90, 0);

                Instantiate(bullet, hand.position, bulletRotation);
            bulletTimer = 1f;
        }
        if (stateAvoidDanger == false)
        { 
            agent.SetDestination(player.position);
        }
    }
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player have found");
            canShoot = true;
        }
        if (other.gameObject.CompareTag("DangerZone"))
        {
            StartCoroutine(WaitAndPrint());
            stateAvoidDanger = true;
            Debug.Log("Robot has enter to the water");
            agent.SetDestination(new Vector3(transform.position.x - 15, transform.position.y, transform.position.z - 15));
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
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canShoot = false;
        }
        if (other.gameObject.CompareTag("DangerZone"))
        {
            Debug.Log("Robot has exit the water");
        }

    }
}