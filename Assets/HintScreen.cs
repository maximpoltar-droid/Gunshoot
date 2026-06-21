using UnityEngine;

public class HintScreen : MonoBehaviour
{
    public GameObject hintScreen;
    public GameObject hintPaper;

    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            hintScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            Destroy(hintPaper);
        }
    }
}
