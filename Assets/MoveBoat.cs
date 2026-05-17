using UnityEngine;

public class MoveBoat : MonoBehaviour
{
    private Transform destination;
    public Transform destination1;
    public Transform destination2;
    public Transform destination3;
    public Transform destination4;
    private float speed = 10f;

    private void Start()
    {
        destination = destination1;
    }
    private void Update()
    {
        if (destination == null) return;
        
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destin1"))
        {
            destination = destination2;
        }
        if (other.gameObject.CompareTag("Destin2"))
        {
            destination = destination3;
        }
        if (other.gameObject.CompareTag("Destin3"))
        {
            destination = destination4;
        }
    } 
}
