using UnityEngine;
using UnityEngine.SceneManagement; // For scene management

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Player loses - Load LoseScene
            SceneManager.LoadScene("LoseScene");
        }
    }
}
