using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeartsCounter : MonoBehaviour
{
    public static int hearts;
    public TextMeshProUGUI heartcounter;
    void Update()
    {
        heartcounter.text = "" + hearts;
    }

}
