using UnityEngine;

public class TankyEnemy : MonoBehaviour
{
    public int health = 3;
    public float fallSpeed = 2f;
    public int scoreValue = 30;

    private void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0) return; // Prevents unnecessary execution

        AudioManager.Instance?.PlaySound(AudioManager.Instance.explosionClip);
        GameManager.Instance?.EnemyDestroyed();
        ScoreManager.Instance?.AddScore(scoreValue);

        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
