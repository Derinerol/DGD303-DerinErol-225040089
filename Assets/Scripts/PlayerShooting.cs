using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the Bullet prefab
    public Transform bulletSpawnPoint; // Reference to the position where bullets spawn
    public float bulletSpeed = 10f; // Speed at which bullets move
    public float fireRate = 0.2f; // Time between shots

    private float nextFireTime = 0f; // Tracks when the player can fire again

    void Update()
    {
        // Check if the player presses the Space key and if firing is allowed
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate; // Set the cooldown for firing
        }
    }

    void Shoot()
    {
        // Spawn a bullet at the specified bulletSpawnPoint position
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        // Add Rigidbody2D to the bullet and set its velocity
        Rigidbody2D rb = bullet.AddComponent<Rigidbody2D>();
        rb.gravityScale = 0; // Prevent gravity from affecting the bullet
        rb.velocity = Vector2.up * bulletSpeed; // Move the bullet upward

        // Play shooting sound
        AudioManager.Instance.PlaySound(AudioManager.Instance.shootClip);

        // Destroy the bullet after 5 seconds to clean up the scene
        Destroy(bullet, 5f);
    }
}
