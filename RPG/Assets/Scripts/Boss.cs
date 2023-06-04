using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public static bool bossactive;
    void Start()
    {
        bossactive = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Bullet"))
        {
            bossactive = true;
        }
    }
}
