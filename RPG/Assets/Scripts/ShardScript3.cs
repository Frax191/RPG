using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static YesorNo;
using static Barrier;

public class ShardScript3 : MonoBehaviour
{
    public AudioSource pickup;
    public static bool trigger3;
    public Animator chest3;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (trigger3 == false)
            {
                pickup.Play();
                shards += 1;
                chest3.SetBool("Chest2", true);
                trigger3 = true;
            }
        }
    }
    void Update()
    {
        if (trigger3 == false)
        {
            chest3.SetBool("Chest2", false);
        }
    }
}