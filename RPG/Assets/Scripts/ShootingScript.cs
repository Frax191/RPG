using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public float shootCooldown = 0.5f;
    public AudioSource Shooting;
    public Animator Anim1;
    public Animator Anim2;
    public Animator Anim3;

    private float nextShootTime;

    private void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextShootTime && Anim1.GetBool("IsOpen") == false && Anim2.GetBool("DifficultyShow") == false && Anim3.GetBool("shop") == false)
        {
            Shoot();
            Shooting.Play();
            nextShootTime = Time.time + shootCooldown;
        }
    }

    private void Shoot()
    {
        // Calculate the direction from the shooting GameObject to the mouse position
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        direction.Normalize();

        // Create a new bullet instance
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        // Get the bullet's Rigidbody2D component
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        // Set the bullet's velocity based on the direction towards the mouse
        bulletRb.velocity = direction * bulletSpeed;

        // Calculate the rotation angle in degrees based on the direction
        float rotationAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Adjust the rotation angle for vertical sprite
        rotationAngle += 90f;

        // Apply the rotation to the bullet
        bullet.transform.rotation = Quaternion.Euler(0f, 0f, rotationAngle);
    }

}