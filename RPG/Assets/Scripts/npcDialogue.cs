using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDialogue : MonoBehaviour
{
    public GameObject player;
    public static bool cattalk;
    private void OnTriggerEnter2D(Collider2D other)
    {
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
