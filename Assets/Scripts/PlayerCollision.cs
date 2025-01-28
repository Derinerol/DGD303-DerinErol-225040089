using UnityEngine;
using UnityEngine.SceneManagement; // For scene management

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is tagged as "Enemy" or "TankyEnemy"
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("TankyEnemy"))
        {
            // Player loses - Load LoseScene
            SceneManager.LoadScene("LoseScene");
        }
    }
}
