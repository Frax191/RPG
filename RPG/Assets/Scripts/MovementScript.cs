using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform wandTransform;  // Reference to the wand's transform

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

        // Check for horizontal input and update the player sprite and wand's position
        if (moveHorizontal > 0)
        {
            spriteRenderer.flipX = false;  // Face right
            wandTransform.localPosition = new Vector3(0.5f, 0f, 0f);  // Set wand position to the right of the player
        }
        else if (moveHorizontal < 0)
        {
            spriteRenderer.flipX = true;  // Face left
            wandTransform.localPosition = new Vector3(-0.5f, 0f, 0f);  // Set wand position to the left of the player
        }
    }
}
