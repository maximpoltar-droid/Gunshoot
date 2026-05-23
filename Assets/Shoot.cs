using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot
    : MonoBehaviour
{
    public ParticleSystem fire;
    private float range = 100;
    private AudioSource audioSource;
    public AudioClip Sound_01;
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
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(Sound_01, 1f);
        if (StartGame.pause == false)
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

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
}
