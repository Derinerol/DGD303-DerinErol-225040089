using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Array of enemy prefabs
    public float spawnInterval = 2f; // Time between spawns
    public float spawnRangeX = 8f; // Horizontal range for spawning
    public float spawnY = 6f; // Spawn position on the Y-axis

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), spawnInterval, spawnInterval);
    }

    private void SpawnEnemy()
    {
        // Randomly select an enemy prefab
        int randomIndex = Random.Range(0, enemyPrefabs.Length);
        GameObject selectedEnemy = enemyPrefabs[randomIndex];

        // Randomize spawn position
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0);

        // Instantiate the enemy
        Instantiate(selectedEnemy, spawnPosition, Quaternion.identity);
    }
}
