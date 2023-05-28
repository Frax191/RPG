using UnityEngine;

public class bulletbreaker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Ignore collisions with objects tagged as "Player" or if the collider is a trigger
        if (other.CompareTag("Player") || other.isTrigger)
            return;

        Combat_Enemy enemy = other.GetComponent<Combat_Enemy>();
        Combat_Boss boss = other.GetComponent<Combat_Boss>();

        if (enemy != null)
        {
            enemy.TakeDamage(Base_stats.P_ATK);
        }
        else if (boss != null && other.CompareTag("Boss"))
        {
            boss.TakeDamage(Base_stats.P_ATK);
        }

        // Destroy the bullet when it collides with something
        Destroy(gameObject);
    }
}
