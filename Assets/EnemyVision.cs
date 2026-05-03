using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    /*   public Transform player;
       public float visionRange = 20f;
       public float visionAngle = 60f;
       public LayerMask obstacleLayer;

       private bool playerInVision = false;

       void Start()
       {
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
           CheckPlayerInVision();
       }

       void CheckPlayerInVision()
       {
           if (player == null) return;

           float distanceToPlayer = Vector3.Distance(transform.position, player.position);

           // Проверяем расстояние до игрока
           if (distanceToPlayer <= visionRange)
           {
               Vector3 directionToPlayer = (player.position - transform.position).normalized;

               // Проверяем угол обзора
               float angle = Vector3.Angle(transform.forward, directionToPlayer);
               if (angle <= visionAngle / 2f)
               {
                   // Проверяем, нет ли препятствий
                   if (!Physics.Raycast(transform.position, directionToPlayer, distanceToPlayer, obstacleLayer))
                   {
                       // Игрок в зоне видимости!
                       if (!playerInVision)
                       {
                           playerInVision = true;
                           OnPlayerEnterVision();
                       }
                       return;
                   }
               }
           }

           // Игрок не в зоне видимости
           if (playerInVision)
           {
               playerInVision = false;
               OnPlayerExitVision();
           }
       }

       void OnPlayerEnterVision()
       {
           Debug.Log("Игрок в зоне видимости!");
           // Здесь можно добавить логику начала стрельбы
       }

       void OnPlayerExitVision()
       {
           Debug.Log("Игрок вышел из зоны видимости!");
           // Здесь можно добавить логику прекращения стрельбы
       }

       // Метод для проверки, видит ли враг игрока
       public bool CanSeePlayer()
       {
           return playerInVision;
       }*/
}
