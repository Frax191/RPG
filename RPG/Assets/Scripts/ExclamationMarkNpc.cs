using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Combat_Boss;
using static DialogueManager;

public class ExclamationMarkNpc : MonoBehaviour
{
    private bool triggered;
    void Start()
    {
        transform.position = new Vector2(1000f, 1000f);
    }
    void Update()
    {
        if (defeated == true && triggered == false)
        {
            transform.position = new Vector2(-4f, 3f);
            triggered = true;
        }
        if (triggershop == true)
        {
            transform.position = new Vector2(1000f, 1000f);
        }
    }
}
