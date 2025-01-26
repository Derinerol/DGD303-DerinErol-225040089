using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsPanel; // Reference to the Credits Panel

    // Start the game
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene"); // Replace with the name of your game scene
    }

    // Open the credits panel
    public void OpenCredits()
    {
        creditsPanel.SetActive(true); // Show the Credits Panel
    }

    // Close the credits panel
    public void CloseCredits()
    {
        creditsPanel.SetActive(false); // Hide the Credits Panel
    }

    // Quit the game
    public void QuitGame()
    {
        Application.Quit(); // Works in the build, not in the editor
        Debug.Log("Quit Game"); // Debug log for testing in the editor
    }
}
