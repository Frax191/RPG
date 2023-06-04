using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueManager;

public class shopping_trigger : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    void Start()
    {
        transform.position = new Vector2(1000f, 1000f);
    }
    void Update()
    {
        if (triggershop == true)
        {
            transform.position = new Vector2(0f, 2.5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            MovementScript movementScript = player.GetComponent<MovementScript>();
            movementScript.enabled = false;
            animator.SetBool("shop", true);
        }
    }
}
