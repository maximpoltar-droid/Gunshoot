using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 5f;
    
    void Start()
    {
        // Находим игрока по тегу, если не назначен вручную
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
            {
                player = playerObj.transform;
            }
            else
            {
                Debug.LogError("Player not found! Make sure the player has the 'Player' tag.");
            }
        }
    }
    
    void Update()
    {
        if (player == null) return;
        
        // Направляем робота на игрока
        Vector3 directionToPlayer = player.position - transform.position;
        
        // Убираем наклон по оси Y, чтобы робот не наклонялся вверх/вниз
        directionToPlayer.y = 0;
        
        if (directionToPlayer != Vector3.zero)
        {
            // Плавный поворот к игроку
            Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
