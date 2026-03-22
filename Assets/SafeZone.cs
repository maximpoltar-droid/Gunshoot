using UnityEngine;
using System;
using System.Collections; 
using System.Collections.Generic;
public class SafeZone : MonoBehaviour
{
    public static bool go = true;
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger1"))
        {
            go = false;
            Debug.Log("Robot has enter to the water");
            Debug.Log(go);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        go = true;
        Debug.Log("Robot has exit the water");
        Debug.Log(go);
    }

}