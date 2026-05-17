using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip TensionPart3Loop;
    public AudioClip StealthSynthLayerLoop;
    public GameObject menu;
    public 

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayButton()
    {
        StartGame.pause = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        menu.SetActive(false);
        audioSource.loop = true;
        audioSource.clip = StealthSynthLayerLoop;
        audioSource.Play();
    }
}
