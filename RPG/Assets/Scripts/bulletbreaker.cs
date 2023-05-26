using UnityEngine;

public class bulletbreaker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Ignore collisions with objects tagged as "Player"
        if (other.CompareTag("Player"))
            return;

        // Destroy the bullet when it triggers with something
        Destroy(gameObject);
    }
}
