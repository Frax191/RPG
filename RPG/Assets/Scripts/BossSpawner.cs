using UnityEngine;
using static YesorNo;

public class BossSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Sprite[] bossSprites;
    public Transform waypoint;
    public Transform waypoint1;
    public Transform waypoint2;

    private GameObject spawnedEnemy;

    public void SpawnEnemy()
    {
        Transform selectedWaypoint = door1e ? waypoint : (door2e ? waypoint1 : (door3e ? waypoint2 : waypoint));
        // Destroy existing enemy
        DestroyExistingEnemy();

        if (selectedWaypoint != null)
        {
            spawnedEnemy = Instantiate(enemyPrefab, selectedWaypoint.position, Quaternion.identity);

            // Randomly select a sprite from the bossSprites array
            int randomSpriteIndex = Random.Range(0, bossSprites.Length);
            SpriteRenderer spriteRenderer = spawnedEnemy.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.sprite = bossSprites[randomSpriteIndex];
            }

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
