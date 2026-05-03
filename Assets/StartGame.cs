using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{
    public static bool pause = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     StartCoroutine(WaitAndPrint());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(1f);

        Debug.Log("Прошла 1 секунда!");
        Time.timeScale = 0f;
        pause = true;
    }
}
