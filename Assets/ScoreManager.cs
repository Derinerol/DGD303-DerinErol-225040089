using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Singleton for global access
    public TextMeshProUGUI scoreText; // Reference to the score display

    private int score = 0; // Internal score tracker

    private void Awake()
    {
        // Ensure only one instance exists
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Method to add points to the score
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    // Updates the score UI
    private void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    // Method to retrieve the current score
    public int GetScore()
    {
        return score;
    }
}
