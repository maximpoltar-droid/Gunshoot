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

        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Прыжок работает только на земле, независимо от движения
        if (Input.GetKeyDown(KeyCode.Space) && groundedPlayer)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Движение по горизонтали (без учета вертикального направления камеры)
        Vector3 move = transform.right * horizontal;
        move.y = 0; // Убираем любую вертикальную компоненту
        Vector3 forward = transform.forward;
        forward.y = 0; // Убираем вертикальную компоненту из направления вперед
        forward.Normalize(); // Нормализуем вектор
        move += forward * vertical;
        
        controller.Move(move * Speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

}

