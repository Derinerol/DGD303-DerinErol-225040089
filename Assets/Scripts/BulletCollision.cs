using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bullet collided with a regular enemy
        if (collision.CompareTag("Enemy"))
        {
            // Play explosion sound
            AudioManager.Instance.PlaySound(AudioManager.Instance.explosionClip);

            // Notify GameManager about enemy destruction
            FindObjectOfType<GameManager>().EnemyDestroyed();

            // Add points to the score
            ScoreManager.Instance.AddScore(10); // Award 10 points for each enemy

            // Destroy the enemy and bullet
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        // Check if the bullet collided with a tanky enemy
        else if (collision.CompareTag("TankyEnemy"))
        {
            // Access the TankyEnemy script and reduce its health
            TankyEnemy tankyEnemy = collision.GetComponent<TankyEnemy>();
            if (tankyEnemy != null)
            {
                tankyEnemy.TakeDamage(1); // Pass damage value (e.g., 1) to TankyEnemy
            }

            // Destroy the bullet regardless of the enemy type
            Destroy(gameObject);
        }
    }
}
