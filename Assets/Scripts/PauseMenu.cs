using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false; // Tracks if the game is paused
    public GameObject pauseMenuUI;      // Reference to the PauseMenu Canvas

    void Update()
    {
        // Toggle pause when pressing the Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);   // Hide the pause menu
        Time.timeScale = 1f;           // Resume the game
        IsPaused = false;
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);   // Show the pause menu
        Time.timeScale = 0f;           // Freeze the game
        IsPaused = true;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;           // Ensure time resumes
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart current level
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;           // Ensure time resumes
        SceneManager.LoadScene("MainMenu"); // Load Main Menu scene
    }

    public void QuitGame()
    {
        Application.Quit(); // Exit the application
    }
}
