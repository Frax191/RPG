using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Base_stats;

public class Combat : MonoBehaviour
{
    private int Health;
    private int Attack;
    void Start()
    {
        Stats();
    }
    void Stats()
    {
        Health = P_HP;
        Attack = P_ATK;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health -= E_ATK;
            if (Health <= 0)
            {
                Health = P_HP;
                transform.position = new Vector2(0, 1);
            }
        }
        else if (collision.gameObject.CompareTag("Boss"))
        {
            Attack -= B_ATK;
            if (Health <= 0)
            {
                Health = P_HP;
                transform.position = new Vector2(0, 1);
            }
        }
    }
}
