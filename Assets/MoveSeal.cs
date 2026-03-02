using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSeal : MonoBehaviour
{
    private bool groundedPlayer;
    public float Speed = 10f;
    public CharacterController controller;
    public float gravity = -10f;
private float jumpHeight = 7f;
private Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
   {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * Speed * Time.deltaTime);

        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKey(KeyCode.Space) && groundedPlayer)
        {
            velocity.y = jumpHeight;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

}

