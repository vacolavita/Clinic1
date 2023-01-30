
using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1f;
    public int maxEnemies = 10;
    private int currentEnemies = 0;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (currentEnemies >= maxEnemies) return;

        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        currentEnemies++;
    }
}