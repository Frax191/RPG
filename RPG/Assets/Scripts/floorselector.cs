using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static RoomNum;

public class floorselector : MonoBehaviour
{
    public GameObject Cover1;
    public GameObject Cover2;
    public GameObject Cover3;
    public Animator animator;
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("FloorSelector", true);
            MovementScript movementScript = player.GetComponent<MovementScript>();
            movementScript.enabled = false;
        }
    }
    void Update()
    {
        if (beaten == 1)
        {
            Cover1.SetActive(false);
        }
        if (beaten == 2)
        {
            Cover2.SetActive(false);
        }
        if (beaten == 3)
        {
            Cover3.SetActive(false);
        }
    }
}
