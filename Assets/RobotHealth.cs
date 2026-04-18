using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class RobotHealth : MonoBehaviour
{
    public GameObject robotKill;
    public int maxHealth = 5;
    private int currentHealth;
    
    void Start()
    {
        robotKill.SetActive(false);
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Robot health: " + currentHealth);
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        Debug.Log("Robot destroyed!");
        robotKill.SetActive(true);
        Destroy(gameObject);
    }
}
