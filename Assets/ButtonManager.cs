using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject menu;
    public void PlayButton()
    {
        StartGame.pause = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        menu.SetActive(false);
    }
}
