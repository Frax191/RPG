using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static Door1;
using static Door2;
using static Door3;
using static door5;

public class Door1 : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    public TextMeshProUGUI texttochange;
    public static bool door1;
    public GameObject otherGameObject;
    void Start()
    {
        door1 = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
            return;
        CloseDifficulty closeDifficultyScript = otherGameObject.GetComponent<CloseDifficulty>();
        closeDifficultyScript.HideCovers();
        door1 = false;
        door2 = false;
        door3 = false;
        door4 = true;
        MovementScript movementScript = player.GetComponent<MovementScript>();
        movementScript.enabled = false;
        texttochange.text = "Do you wish to go to the Ghost Haven";
        door1 = true;
        animator.SetBool("DifficultyShow", true);
    }
}