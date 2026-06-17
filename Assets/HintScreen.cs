using UnityEngine;

public class HintScreen : MonoBehaviour
{
    public GameObject hintScreen;

    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            hintScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
}
