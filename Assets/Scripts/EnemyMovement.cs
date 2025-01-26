using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f; // Speed of the enemy

    void Update()
    {
        // Move the enemy downward
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Destroy the enemy if it moves off-screen
        if (transform.position.y < -6f) // Adjust -6f based on screen size
        {
            Destroy(gameObject);
        }
    }
}
