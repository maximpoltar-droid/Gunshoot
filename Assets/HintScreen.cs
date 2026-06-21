using UnityEngine;

public class HintScreen : MonoBehaviour
{
    public GameObject hintScreen;
    public GameObject hintPaper;
    public GameObject player;
    public RotationScript rotationscript;
    public Shoot sealshoot;

    void Start()
    {
        rotationscript = player.GetComponent<RotationScript>();
        sealshoot = player.GetComponent<Shoot>();
    }
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            sealshoot.enabled = false;
            rotationscript.enabled = false;
            hintScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            Destroy(hintPaper);
        }
    }
}
