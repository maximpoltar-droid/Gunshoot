using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip TensionPart3Loop;
    public AudioClip StealthSynthLayerLoop;
    public GameObject menu;
    public GameObject player;
    public RotationScript rotationscript;
    public GameObject hintScreen;
    public Shoot sealshoot;


    void Start()
    {
        rotationscript = player.GetComponent<RotationScript>();
        audioSource = GetComponent<AudioSource>();
        sealshoot = player.GetComponent<Shoot>();
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
    public void CloseHint()
    {
        sealshoot.enabled = true;
        rotationscript.enabled = true;
        Debug.Log("button pressed");
        hintScreen.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
