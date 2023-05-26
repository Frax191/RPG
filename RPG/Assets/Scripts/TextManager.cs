using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TMP_Text old1;
    public TMP_Text old2;
    public TMP_Text old3;
    public Image old4;
    public Image old5;
    public Image old6;
    public TMP_Text new1;
    public TMP_Text new2;
    public TMP_Text new3;

    private void Awake()
    {
        // No need to assign in Awake() since the variables will be assigned in the inspector
    }
}
