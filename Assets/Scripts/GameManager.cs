using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton instance

    private int enemiesDestroyed = 0; // Track destroyed enemies
    private int finalScore = 0; // Track player's score

    private void Awake()
    {
        // Ensure there's only one GameManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void EnemyDestroyed()
    {
        enemiesDestroyed++;

        // Check win condition
        if (enemiesDestroyed >= 10)
        {
            // Save the score
            finalScore = ScoreManager.Instance.GetScore();
            SceneManager.LoadScene("WinScene");
        }
    }

    public void PlayerDied()
    {
        // Save the score
        finalScore = ScoreManager.Instance.GetScore();
        SceneManager.LoadScene("LoseScene");
    }

    public int GetFinalScore()
    {
        return finalScore;
    }
}
