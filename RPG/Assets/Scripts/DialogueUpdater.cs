using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueUpdater : MonoBehaviour
{
    Dialogue myInstance = new Dialogue();
    public static bool triggered;
    void Start()
    {
        triggered = false;
    }

    private void Update()
    {
//        myInstance.SentencesUpdate();
    }
}
