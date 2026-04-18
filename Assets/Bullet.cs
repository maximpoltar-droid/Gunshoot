using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20.0f;
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * bulletSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
