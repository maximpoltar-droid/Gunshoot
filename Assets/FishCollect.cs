using UnityEngine; // Основная библиотека Unity
using System; // Для Array, String и т.д.
using System.Collections; // Для корутин (не обязательно для тегов)
using System.Collections.Generic; // Для List, Dictionary
using TMPro;


public class FishCollect : MonoBehaviour


{
    public TextMeshProUGUI eattenFishText;
    public int eattenFish = 0;
    void Start()
    {
        eattenFish = 0;
        eattenFishText.text = "EATEN FISH = " + eattenFish.ToString();     
    }

    void Update()
    {

    }
        private void OnCollisionEnter(Collision collision)
    {
             if (collision.gameObject.CompareTag("Fish"))
        {
            Debug.Log("Seal ate fish");
            eattenFish += 1;
            eattenFishText.text ="EATEN FISH = "+ eattenFish.ToString();
            Destroy(collision.gameObject);
        }
    }
}

