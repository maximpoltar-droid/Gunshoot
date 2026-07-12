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
    public Animator shoot;
    private float timer;
    private float timeValue = 0.45f;
    private void Start()
    {
        timer = timeValue;
}
    void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && timer <= 0)
        {
            fire.Play();
            Shoots();
            shoot.SetTrigger("Shoot");
            timer = timeValue;
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
