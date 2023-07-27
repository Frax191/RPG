using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Combat_Boss;
using static DialogueManager;
using static Barrier;
using static Door4;
using static SageScript;

public class ExclamationMarkNpc : MonoBehaviour
{
    private bool triggered1;
    private bool triggered2;
    private bool triggered3;
    private bool triggered4;
    private bool triggered5;
    private bool triggered6;
    private bool triggered7;
    void Start()
    {
        transform.position = new Vector2(-4f, 3f);
    }
    void Update()
    {
        if (obtainheart == true & triggered7 == false)
        {
            transform.position = new Vector2(1000f, 1000f);
            triggered7 = true;
        }
        if (defeated == true && triggered1 == false)
        {
            transform.position = new Vector2(-4f, 3f);
            triggered1 = true;
        }
        if (changedialogue == true & triggered2 == false)
        {
            transform.position = new Vector2(-4f, 3f);
            triggered2 = true;
        }
        if (triggershop == true & triggered3 == false)
        {
            transform.position = new Vector2(1000f, 1000f);
            triggered3 = true;
        }
        if (talkto == true & triggered4 == false)
        {
            transform.position = new Vector2(1000f, 1000f);
            triggered4 = true;
        }
        if (beatgame == true & triggered5 == false)
        {
            transform.position = new Vector2(-4f, 3f);
            triggered5 = true;
        }
        if (talkto2 == true & triggered6 == false)
        {
            transform.position = new Vector2(1000f, 1000f);
            triggered6 = true;
        }
    }
}
