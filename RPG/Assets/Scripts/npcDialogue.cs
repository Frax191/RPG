using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDialogue : MonoBehaviour
{
    public static bool cattalk;
    private void OnTriggerEnter2D(Collider2D other)
    {
        DialogueTrigger dialogueTrigger = GetComponent<DialogueTrigger>();
        if (dialogueTrigger != null)
        {
            cattalk = true;
            dialogueTrigger.TriggerDialogue();

        }
    }
    void Start()
    {
        cattalk = false;
    }
}
