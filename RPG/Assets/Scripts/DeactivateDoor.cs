using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SageScript;

public class DeactivateDoor : MonoBehaviour
{
    public GameObject ObjectToDeactivate;
    void Update()
    {
        if (getkeys == true)
        {
            ObjectToDeactivate.SetActive(false);
        }
    }
}
    