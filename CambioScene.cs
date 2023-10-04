using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioScene : MonoBehaviour
{
    public GameObject pausePanel;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadNextScene);
    }

    void LoadNextScene()
    {
        Time.timeScale = 1f; // Reanuda el tiempo
        pausePanel.SetActive(false); // Desactiva el panel de pausa
        SceneManager.LoadScene("Colores"); // Carga la siguiente escena
    }
}
