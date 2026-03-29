using UnityEngine;
using TMPro;

public class RobotHealth : MonoBehaviour
{
    public TextMeshProUGUI robotKill;
    public int maxHealth = 5;
    private int currentHealth;
    
    void Start()
    {
        robotKill.transform.position.y = 100;
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
        robotKill.transform.position.y = - 122;
    }
}
