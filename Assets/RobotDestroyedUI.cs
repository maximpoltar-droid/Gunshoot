using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RobotDestroyedUI : MonoBehaviour
{
    public static RobotDestroyedUI Instance;
    
    public GameObject robotDestroyedText;
    public TextMeshProUGUI textComponent;
    
    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        // Скрываем текст в начале
        if (robotDestroyedText != null)
        {
            robotDestroyedText.SetActive(false);
        }
    }
    
    public void ShowRobotDestroyed()
    {
        if (robotDestroyedText != null)
        {
            robotDestroyedText.SetActive(true);
            
            // Запускаем корутину для скрытия текста через 4 секунды
            StartCoroutine(HideTextAfterDelay(4f));
        }
    }
    
    System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        
        if (robotDestroyedText != null)
        {
            robotDestroyedText.SetActive(false);
        }
    }
}
