using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform waypoint;

    private GameObject spawnedEnemy;

    public void SpawnEnemy()
    {
        // Destroy existing enemy
        DestroyExistingEnemy();

        // Spawn new enemy at the specified waypoint
        if (waypoint != null)
        {
            spawnedEnemy = Instantiate(enemyPrefab, waypoint.position, Quaternion.identity);
            spawnedEnemy.name = "Enemy";
        }
    }

    private void DestroyExistingEnemy()
    {
        if (spawnedEnemy != null)
        {
            Destroy(spawnedEnemy);
        }
    }
}
