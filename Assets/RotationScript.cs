using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    private float horSpeed = 5;
    private float verSpeed = 5;
    private float minVert = -45;
    private float maxVert = 45;
    private float rotationX;
    private float rotationY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y") * verSpeed;
        rotationX = Mathf.Clamp(rotationX, minVert, maxVert);
        float delta = Input.GetAxis("Mouse X") * horSpeed;
        rotationY = transform.localEulerAngles.y + delta;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
