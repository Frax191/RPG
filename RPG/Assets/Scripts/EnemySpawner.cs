using UnityEngine;
using static YesorNo;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Sprite[] enemySprites; // Array of sprites to use for enemy visuals
    public Transform[] waypoints;
    public Transform[] waypoints2;
    public Transform[] waypoints3;

    private GameObject[] spawnedEnemies;

    public void SpawnEnemies()
    {
        int numberOfEnemies = 10;

        Transform[] selectedWaypoints = door1e ? waypoints : (door2e ? waypoints2 : (door3e ? waypoints3 : waypoints));

        // Shuffle the waypoints array
        for (int i = 0; i < selectedWaypoints.Length - 1; i++)
        {
            int randomIndex = Random.Range(i, selectedWaypoints.Length);
            Transform temp = selectedWaypoints[i];
            selectedWaypoints[i] = selectedWaypoints[randomIndex];
            selectedWaypoints[randomIndex] = temp;
        }

        // Destroy existing enemies
        DestroyExistingEnemies();

        // Spawn new enemies at random waypoints with random sprites
        spawnedEnemies = new GameObject[numberOfEnemies];
        for (int i = 0; i < numberOfEnemies; i++)
        {
            if (selectedWaypoints[i] != null)
            {
                GameObject enemy = Instantiate(enemyPrefab, selectedWaypoints[i].position, Quaternion.identity);

                // Randomly select a sprite from the enemySprites array
                int randomSpriteIndex = Random.Range(0, enemySprites.Length);
                SpriteRenderer spriteRenderer = enemy.GetComponent<SpriteRenderer>();
                if (spriteRenderer != null)
                {
                    spriteRenderer.sprite = enemySprites[randomSpriteIndex];
                }

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
