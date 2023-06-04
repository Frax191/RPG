using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] waypoints;

    private GameObject[] spawnedEnemies;

    public void SpawnEnemies()
    {
        int numberOfEnemies = 10;

        // Shuffle the waypoints array
        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            int randomIndex = Random.Range(i, waypoints.Length);
            Transform temp = waypoints[i];
            waypoints[i] = waypoints[randomIndex];
            waypoints[randomIndex] = temp;
        }

        // Destroy existing enemies
        DestroyExistingEnemies();

        // Spawn new enemies at random waypoints
        spawnedEnemies = new GameObject[numberOfEnemies];
        for (int i = 0; i < numberOfEnemies; i++)
        {
            if (waypoints[i] != null)
            {
                GameObject enemy = Instantiate(enemyPrefab, waypoints[i].position, Quaternion.identity);
                enemy.name = "Enemy " + (i + 1);
                spawnedEnemies[i] = enemy;
            }
        }
    }

    private void DestroyExistingEnemies()
    {
        if (spawnedEnemies != null)
        {
            foreach (GameObject enemy in spawnedEnemies)
            {
                if (enemy != null)
                {
                    Destroy(enemy);
                }
            }
        }
    }
}
