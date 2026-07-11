using UnityEngine;

public class HitShovel : MonoBehaviour
{
    public Animator shovelAtkAnim;
    private BoxCollider shovelCollider;
    private float timer;
    private float timeValue = 0.7f;
    public GameObject robot;
    private RobotHealth robotHealth;

    private void Start()
    {
        robotHealth = robot.GetComponent<RobotHealth>();
        shovelCollider = GetComponent<BoxCollider>();
        timer = timeValue;
    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        } else
        {
            shovelCollider.enabled = false;
            timer = timeValue;
        }

        if (Input.GetMouseButtonDown(1))
        {
            shovelCollider.enabled = true;
            shovelAtkAnim.SetTrigger("Hit");
        }

    }
     void OnTriggerEnter(Collider other)
    {
        Debug.Log("On trig enter");
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("shovelColl compare tag Enemy");
            if (robotHealth != null)
            {
                Debug.Log("Robot took damage");
                robotHealth.TakeDamage(1);
            }
        }
    }
}
