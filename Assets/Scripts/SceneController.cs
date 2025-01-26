using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene"); // Replace with your main scene name
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
