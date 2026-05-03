using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
/*    public Transform player;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    public float bulletSpeed = 10f;
    public float shootingRange = 25f;
    
    private EnemyVision enemyVision;
    private float nextFireTime = 0f;
    
    void Start()
    {
        enemyVision = GetComponent<EnemyVision>();
        
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
            {
                player = playerObj.transform;
            }
        }
    }
    
    void Update()
    {
        if (CanShoot())
        {
            Shoot();
        }
    }
    
    bool CanShoot()
    {
        // Проверяем, видит ли враг игрока
        if (enemyVision != null && !enemyVision.CanSeePlayer())
        {
            return false;
        }
        
        // Проверяем расстояние до игрока
        if (player == null) return false;
        
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        return distanceToPlayer <= shootingRange && Time.time >= nextFireTime;
    }
    
    void Shoot()
    {
        if (bulletPrefab == null || firePoint == null) return;
        
        // Создаем пулю
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        // Добавляем скорость пуле
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        if (bulletRb != null)
        {
            Vector3 directionToPlayer = (player.position - firePoint.position).normalized;
            bulletRb.linearVelocity = directionToPlayer * bulletSpeed;
        }
        
        // Устанавливаем время следующего выстрела
        nextFireTime = Time.time + 1f / fireRate;
        
        Debug.Log("Враг выстрелил в игрока!");
    }*/
}
