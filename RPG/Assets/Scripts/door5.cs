using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Door4;
using TMPro;
using UnityEngine.UI;
using static Door1;
using static Door2;
using static Door3;

public class door5 : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    public TextMeshProUGUI texttochange;
    public TextMeshPro textoverdoor;
    public static bool door4;
    void Update()
    {
        if (beatgame == true)
        {
            textoverdoor.text = "Tower   Of Hell";
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (beatgame == true)
            {
                door1 = false;
                door2 = false;
                door3 = false;
                door4 = true;
                MovementScript movementScript = player.GetComponent<MovementScript>();
                movementScript.enabled = false;
                texttochange.text = "Do you wish to go to the Tower of Hell";
                animator.SetBool("DoorOpen", true);
            }
        }
    }
}
