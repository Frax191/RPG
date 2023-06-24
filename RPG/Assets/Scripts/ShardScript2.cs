using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static YesorNo;
using static Barrier;

public class ShardScript2 : MonoBehaviour
{
    public AudioSource pickup;
    public static bool trigger2;
    public Animator chest2;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (trigger2 == false)
            {
                pickup.Play();
                shards += 1;
                chest2.SetBool("Chest1", true);
                trigger2 = true;
            }
        }
    }
    void Update()
    {
        if (trigger2 == false)
        {
            chest2.SetBool("Chest1", false);
        }
    }
}