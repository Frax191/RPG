using UnityEngine;
using static YesorNo;

public class BossSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform waypoint;
    public Transform waypoint1;
    public Transform waypoint2;

    private GameObject spawnedEnemy;

    public void SpawnEnemy()
    {
        // Destroy existing enemy
        DestroyExistingEnemy();

        // Spawn new enemy at the specified waypoint
        if (waypoint != null & door1e == true)
        {
            spawnedEnemy = Instantiate(enemyPrefab, waypoint.position, Quaternion.identity);
            spawnedEnemy.name = "Boss";
        }
        if (waypoint != null & door2e == true)
        {
            spawnedEnemy = Instantiate(enemyPrefab, waypoint1.position, Quaternion.identity);
            spawnedEnemy.name = "Boss";
        }
        if (waypoint != null & door3e == true)
        {
            spawnedEnemy = Instantiate(enemyPrefab, waypoint2.position, Quaternion.identity);
            spawnedEnemy.name = "Boss";
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
