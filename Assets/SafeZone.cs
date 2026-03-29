using UnityEngine;
using System;
using System.Collections; 
using System.Collections.Generic;
public class SafeZone : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Robot has exit the water");
    }

}