using UnityEngine;
using TMPro;

public class RobotHealth : MonoBehaviour
{
    public TextMeshProUGUI robotKill;
    public int maxHealth = 5;
    private int currentHealth;
    
    void Start()
    {
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
        Destroy(gameObject);
    }
}
