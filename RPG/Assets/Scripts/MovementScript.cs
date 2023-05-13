using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        // Moves the Player
        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized;
        rb.position += movement * moveSpeed * Time.fixedDeltaTime;

        // Check for horizontal input and flip the sprite horizontally if necessary
        if (moveHorizontal > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveHorizontal < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
