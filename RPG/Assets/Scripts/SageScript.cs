using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SageScript : MonoBehaviour
{
    public GameObject player;
    public static bool getkeys;
    void Start()
    {
        getkeys = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        DialogueTrigger dialogueTrigger = GetComponent<DialogueTrigger>();
        if (dialogueTrigger != null)
        {
            dialogueTrigger.TriggerDialogue();
            MovementScript movementScript = player.GetComponent<MovementScript>();
            movementScript.enabled = false;
        }
    }
}
