using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static YesorNo;
using static Barrier;

public class ShardScript1 : MonoBehaviour
{
    public AudioSource pickup;
    public static bool trigger1;
    public Animator chest1;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (trigger1 == false)
            {
                pickup.Play();
                shards += 1;
                chest1.SetBool("Chest", true);
                trigger1 = true;
            }
        }
    }
    void Update()
    {
        if (trigger1 == false)
        {
            chest1.SetBool("Chest", false);
        }
    }
}