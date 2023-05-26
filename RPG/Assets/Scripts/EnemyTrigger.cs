using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueManager;

public class EnemyTrigger : MonoBehaviour
{
    private bool triggered;
    private MusicPlayer musicPlayer;
    public GameObject player;
    public static bool TriggerEnemy;
    public static bool TriggerTriggerEnemy;
    void Start()
    {
        triggered = false;
        TriggerEnemy = false;
        TriggerTriggerEnemy = false;
        GameObject musicPlayerObject = GameObject.Find("Manager");
        musicPlayer = musicPlayerObject.GetComponent<MusicPlayer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        DialogueTrigger dialogueTrigger = GetComponent<DialogueTrigger>();
        if (other.CompareTag("Player") && triggered == false)
        {
            if (dialogueTrigger != null)
            {
                musicPlayer.TogglePause();
                TriggerTriggerEnemy = true;
                dialogueTrigger.TriggerDialogue();
                MovementScript movementScript = player.GetComponent<MovementScript>();
                movementScript.enabled = false;
                triggered = true;
            }
        }
    }   
}
