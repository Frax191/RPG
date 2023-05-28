using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static Door1;
using static Door2;
using static Door3;

public class Door3 : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    public TextMeshProUGUI texttochange;
    public static bool door3;
    void Start()
    {
        door3 = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
            return;
        door1 = false;
        door2 = false;
        door3 = false;
        MovementScript movementScript = player.GetComponent<MovementScript>();
        movementScript.enabled = false;
        texttochange.text = "Do you wish to go to the Demon Den";
        door3 = true;
        animator.SetBool("DifficultyShow", true);
    }
}
