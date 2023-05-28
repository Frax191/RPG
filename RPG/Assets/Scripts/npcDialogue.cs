using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDialogue : MonoBehaviour
{
    public GameObject player;
    public static bool cattalk;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            return;
        }
        DialogueTrigger dialogueTrigger = GetComponent<DialogueTrigger>();
        if (dialogueTrigger != null)
        {
            cattalk = true;
            dialogueTrigger.TriggerDialogue();
            MovementScript movementScript = player.GetComponent<MovementScript>();
            movementScript.enabled = false;
        }
    }
    void Start()
    {
        cattalk = false;
    }
}
