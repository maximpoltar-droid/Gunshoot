using UnityEngine;

public class MoveBoat : MonoBehaviour
{
    private Transform destination;
    public Transform destination1;
    public Transform destination2;
    public Transform destination3;
    public Transform destination4;
    private float speed = 10f;
    public GameObject seal;
    private bool sealInBoat = false;
    public Vector3 sealOffset = new Vector3(0, 2f, 0); // Смещение тюленя относительно лодки


    private void Start()
    {
        destination = destination1;
    }
    private void Update()
    {
        if (destination != null && FishCollect.eattenFish == 4)
        {
            float distance = Vector3.Distance(transform.position, destination.position);

            float timeToDestination = distance / speed;

            if (timeToDestination > 0)
            {
                float rotationSpeed = 1f / timeToDestination;
                Quaternion targetRotation = destination.rotation;
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
            transform.position = Vector3.MoveTowards(transform.position, destination.position, speed * Time.deltaTime);
        }
        
        // Если тюлень в лодке, обновляем его позицию
        if (sealInBoat && seal != null)
        {
            seal.transform.position = transform.position + sealOffset;
            seal.transform.rotation = transform.rotation * Quaternion.Euler(0, 180f, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && destination != destination3 && destination != destination4)
        {
            Debug.Log("working1");
            destination = destination3;
            sealInBoat = true;
            
            // Отключаем CharacterController тюленя чтобы он не падал
            CharacterController sealController = other.GetComponent<CharacterController>();
            if (sealController != null)
            {
                sealController.enabled = false;
            }
        }
        if (other.gameObject.CompareTag("Destin1"))
        {
            destination = destination2;
        }
        if (other.gameObject.CompareTag("Destin3"))
        {
            destination = destination4;
        }
        if (other.gameObject.CompareTag("Destin4"))
        {
            Debug.Log("working3");
            sealInBoat = false;
            
            // Включаем CharacterController тюленя
            if (seal != null)
            {
                CharacterController sealController = seal.GetComponent<CharacterController>();
                if (sealController != null)
                {
                    sealController.enabled = true;
                }
            }
        }
    }
}
