using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    private int hp = 5;
    public Slider bar;
    public GameObject image;
    void Start()
    {
        image.SetActive(false);
        bar.value = hp;
    }

    void Update()
    {
        bar.value = hp;
        if (hp <= 0)
        {
            Debug.Log("Game over");
            image.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log(hp);
            hp -= 1;

        }
    }
}
