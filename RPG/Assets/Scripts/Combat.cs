using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Base_stats;

public class Combat : MonoBehaviour
{
    public static bool died;
    private int Health;
    private int Attack;
    private MusicPlayer musicPlayer;
    public GameObject musicPlayerObject; // Declare the musicPlayerObject variable
    public Combat_Boss combatBossScript;

    public void Start()
    {
        died = false;
        Stats();
        musicPlayer = musicPlayerObject.GetComponent<MusicPlayer>();
        AudioSource bossmusic = combatBossScript.bossmusic;
    }

    public void Stats()
    {
        Health = P_HP;
        Attack = P_ATK;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health -= E_ATK;
            if (Health <= 0)
            {
                Health = P_HP;
                died = true;
                transform.position = new Vector2(0, 1);
            }
        }
        else if (collision.gameObject.CompareTag("Boss"))
        {
            Health -= B_ATK;
            if (Health <= 0)
            {
                Health = P_HP;
                died = true;
                transform.position = new Vector2(0, 1);
            }
        }
    }
}
