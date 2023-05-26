using UnityEngine;

public class EnemyKnockback : MonoBehaviour
{
    public float knockbackForce = 10f;
    public float knockbackDuration = 0.5f;

    private Rigidbody2D rb;
    private bool isKnockbackActive = false;
    private Vector2 knockbackDirection;
    private float knockbackTimer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Calculate the knockback direction away from the player
            knockbackDirection = transform.position - collision.gameObject.transform.position;
            knockbackDirection.Normalize();

            // Start the knockback
            if (!isKnockbackActive)
            {
                isKnockbackActive = true;
                knockbackTimer = knockbackDuration;
            }
        }
    }

    private void FixedUpdate()
    {
        if (isKnockbackActive)
        {
            // Apply the knockback force
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
            knockbackTimer -= Time.fixedDeltaTime;

            if (knockbackTimer <= 0f)
            {
                // Knockback duration has ended
                isKnockbackActive = false;
            }
        }
    }
}
