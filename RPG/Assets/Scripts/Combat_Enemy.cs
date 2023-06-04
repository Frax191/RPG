using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Base_stats;
using static HeartsCounter;

public class Combat_Enemy : MonoBehaviour
{
    private int Health;
    private int Attack;
    public AudioSource GetHit;

    void Start()
    {
        Stats();
    }
    public void Stats()
    {
        Health = E_HP;
        Attack = E_ATK;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        GetHit.Play();
        if (Health <= 0)
        {
            hearts += 10 * B_HP_M;
            Invoke("DestroyEnemy", .05f);
        }
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
