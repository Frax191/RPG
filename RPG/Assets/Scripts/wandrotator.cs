/*using UnityEngine;

public class wandrotator : MonoBehaviour
{  
    public Transform playerTransform;  // Reference to the player's transform
    public float rotationSpeed = 10f;  // Speed of rotation

   private void Update()
    {
        // Get the direction from the player to the weapon
        Vector2 direction = transform.position - playerTransform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply rotation to the weapon
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}*/
