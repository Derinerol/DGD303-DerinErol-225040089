using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;    // Reference to the Main Menu panel
    public GameObject creditsMenu; // Reference to the Credits panel

    public void ShowCredits()
    {
        mainMenu.SetActive(false);    // Hide the main menu
        creditsMenu.SetActive(true); // Show the credits screen
    }

    public void BackToMainMenu()
    {
        creditsMenu.SetActive(false); // Hide the credits screen
        mainMenu.SetActive(true);    // Show the main menu
    }
}
