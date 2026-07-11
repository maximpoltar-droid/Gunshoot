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
    private float timeValue = 0.4f;
    private float timer1;
    private float timeValue1 = 1.5f;
    private bool canShoot;
    private void Start()
    {
        timer = timeValue;
        timer1 = timeValue1;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        timer1 -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && canShoot == true)
        {
            fire.Play();
            Shoots();
            shoot.SetTrigger("Shoot");
            timer1 = timeValue1;
        }
        if (timer1 <= 0)
        {
            canShoot = true;
        }
    }

    private void Shoots()
    {
        if (timer <= 0)
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
}
