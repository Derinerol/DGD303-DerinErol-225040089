using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private const int winScoreThreshold = 300; // Win condition

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

    private void Start()
    {
        ResetGame();
    }

    public void EnemyDestroyed()
    {
        if (ScoreManager.Instance.GetScore() >= winScoreThreshold)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    public void PlayerDied()
    {
        SceneManager.LoadScene("LoseScene");
    }

    public int GetFinalScore()
    {
        return ScoreManager.Instance?.GetScore() ?? 0; // Directly fetch from ScoreManager
    }

    public void ResetGame()
    {
        Debug.Log("Game Reset! Score cleared.");
        ScoreManager.Instance?.ResetScore();
    }
}
