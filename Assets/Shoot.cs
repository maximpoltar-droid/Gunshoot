using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot
    : MonoBehaviour
{
    public ParticleSystem fire;
    private float range = 100;
    public Camera mainCamera;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fire.Play();
            Shoots();
        }
    }

    private void Shoots()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            
            // Проверяем, попали ли мы в робота
            if (hit.transform.CompareTag("Enemy"))
            {
                RobotHealth robotHealth = hit.transform.GetComponent<RobotHealth>();
                if (robotHealth != null)
                {
                    robotHealth.TakeDamage(1);
                }
            }
        }
    }
}
