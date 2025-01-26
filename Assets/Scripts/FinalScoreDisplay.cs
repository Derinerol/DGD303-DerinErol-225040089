using UnityEngine;
using TMPro;

public class FinalScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText; // Reference to the text object

    private void Start()
    {
        // Get the final score from the GameManager
        int finalScore = GameManager.Instance.GetFinalScore();

        // Update the score text
        finalScoreText.text = "Final Score: " + finalScore;
    }
}
