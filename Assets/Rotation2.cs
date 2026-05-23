using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{

    [Header("Настройки движения")]
    public float moveSpeed = 5f;
    public float sensetivity = 200f;
    private AudioSource audioSource;
    public AudioClip Sound_01;
    private float stepTime = 1f;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }
    void Update()
    {

        //Перемещение
        if (Input.GetKey(KeyCode.W))
        {
            stepTime -= Time.deltaTime;
            if (stepTime == 0f)
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(Sound_01, 1f);

            }
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))    
        {
            stepTime -= Time.deltaTime;
            if (stepTime == 0f)
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(Sound_01, 1f);

            }
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            stepTime -= Time.deltaTime;
            if (stepTime == 0f)
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(Sound_01, 1f);

            }
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            stepTime -= Time.deltaTime;
            if (stepTime <= 0f)
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(Sound_01, 1f);

            }
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);

        }
    }
}