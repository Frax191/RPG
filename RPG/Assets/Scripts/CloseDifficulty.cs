using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Door1;
using static Door2;
using static Door3;

public class CloseDifficulty : MonoBehaviour
{
    public GameObject Cover1;
    public GameObject Cover2;
    public GameObject Cover3;
    public Animator animator;
    public Animator animator2;
    public GameObject player;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && animator.GetBool("DifficultyShow") == true)
        {
            // Triggered when the Escape key is pressed
            ExitDifficulty();
        }
    }
    public void ExitDifficulty()
    {
        MovementScript movementScript = player.GetComponent<MovementScript>();
        movementScript.enabled = true;
        door1 = false;
        door2 = false;
        door3 = false;
        Cover1.SetActive(true);
        Cover2.SetActive(true);
        Cover3.SetActive(true);
        animator.SetBool("DifficultyShow", false);
        animator2.SetBool("DoorOpen", false);
    }
}
