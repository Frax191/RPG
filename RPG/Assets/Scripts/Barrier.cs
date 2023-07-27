using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Barrier : MonoBehaviour
{
    public static bool changedialogue;
    public static int shards;
    public TextMeshPro texttochange;
    void Start()
    {
        shards = 0;
    }
    void Update()
    {
        texttochange.text = "Collect Shards " + shards + "/3";
        if (shards == 3)
        {
            changedialogue = true;
            transform.position = new Vector2(1000f, 1000f);
        }
        if (shards < 3)
        {
            transform.position = new Vector2(-25.9f, -43.8f);
        }
    }
}
