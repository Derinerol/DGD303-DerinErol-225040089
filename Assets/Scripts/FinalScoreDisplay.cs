using UnityEngine;
using TMPro;

public class FinalScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    private void Start()
    {
        finalScoreText.text = $"Final Score: {GameManager.Instance?.GetFinalScore() ?? 0}";
    }
}
