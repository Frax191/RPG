using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Base_stats;

public class Combat_Enemy : MonoBehaviour
{
    private int Health;
    private int Attack;
    public AudioSource GetHit;
    private bool triggered;

    void Start()
    {
        Stats();
    }
    void Stats()
    {
        Health = E_HP;
        Attack = E_ATK;
    }

    public void TakeDamage(int damage)
    {
        if (triggered)
        {
            Health -= damage;
            GetHit.Play();
            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggered = true;
        }
    }
}
