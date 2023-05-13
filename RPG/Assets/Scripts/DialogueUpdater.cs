using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueUpdater : MonoBehaviour
{
    Dialogue myInstance = new Dialogue();

    private void Update()
    {
        myInstance.SentencesUpdate();
    }
}
