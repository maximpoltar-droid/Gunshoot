using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSeal : MonoBehaviour
{
    public float Speed = 10f;
    public CharacterController controller;
    public float gravity = -9.81f;
private float jumpHeight;
private Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
   {
/*        var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        if (input != Vector3.zero)
        {
            transform.Translate(input.normalized * Speed * Time.deltaTime, Space.World);
        }*/
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    Vector3 move = transform.right * horizontal + transform.forward * vertical;
    controller.Move(move * Speed * Time.deltaTime);
    if (Input.GetKey(KeyCode.Space))
        {
            velocity.y = jumpHeight;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

}

