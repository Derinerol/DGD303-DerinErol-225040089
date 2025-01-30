using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<TextMeshProUGUI>();
        }
        scoreText?.SetText($"Score: {score}"); // More efficient way to update text
    }

    public int GetScore() => score;

    public void ResetScore()
    {
        Debug.Log("Resetting score...");
        score = 0;
        UpdateScoreDisplay();
    }
}
