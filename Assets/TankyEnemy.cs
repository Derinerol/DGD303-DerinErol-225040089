using UnityEngine;

public class TankyEnemy : MonoBehaviour
{
    public int health = 3; // Number of hits required to destroy
    public float fallSpeed = 2f; // Speed at which the enemy falls
    public int scoreValue = 30; // Points awarded for destroying this enemy

    void Update()
    {
        // Move the enemy down the screen
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    // Method to handle taking damage
    public void TakeDamage(int damage)
    {
        health -= damage;

        // Check if the enemy is out of health
        if (health <= 0)
        {
            // Notify GameManager about enemy destruction
            FindObjectOfType<GameManager>().EnemyDestroyed();

            // Add points to the score
            ScoreManager.Instance.AddScore(scoreValue);

            // Destroy the tanky enemy
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        // Destroy the tanky enemy when it leaves the screen
        Destroy(gameObject);
    }
}
