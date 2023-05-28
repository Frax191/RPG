using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeartsCounter : MonoBehaviour
{
    public static int hearts;
    public TextMeshProUGUI heartcounter;
    void Start()
    {
        hearts = 10;
    }
    void Update()
    {
        heartcounter.text = "" + hearts;
    }

}
