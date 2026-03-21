using UnityEngine;
using System;
using System.Collections; 
using System.Collections.Generic;
public class SafeZone : MonoBehaviour
{ 
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger1"))
        {
            Debug.Log("Robot has enter to the water");
        }
    }
}