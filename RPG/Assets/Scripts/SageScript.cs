using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SageScript : MonoBehaviour
{
    public GameObject player;
    public static bool getkeys;
    public static bool obtainheart;
    void Start()
    {
        obtainheart = false;
        getkeys = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            return;
        }
        DialogueTrigger dialogueTrigger = GetComponent<DialogueTrigger>();
        if (dialogueTrigger != null)
        {
            dialogueTrigger.TriggerDialogue();
            MovementScript movementScript = player.GetComponent<MovementScript>();
            movementScript.enabled = false;
        }

    }
}
