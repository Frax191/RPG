using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Base_stats;
using UnityEngine.UI;

public class Combat : MonoBehaviour
{
    public Slider slider;
    public static bool died;
    private int Health;
    private int Attack;
    private MusicPlayer musicPlayer;
    public GameObject musicPlayerObject; // Declare the musicPlayerObject variable
    public Combat_Boss combatBossScript;

    public void Start()
    {
        slider.value = 1;
        died = false;
        Stats();
        musicPlayer = musicPlayerObject.GetComponent<MusicPlayer>();
        AudioSource bossmusic = combatBossScript.bossmusic;
    }
    /*void Update()
    {
        Debug.Log(slider.value);
    }*/
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
            slider.value = (float)Health / P_HP;
            if (Health <= 0)
            {
                Health = P_HP;
                slider.value = 1;
                died = true;
                transform.position = new Vector2(0, 1);
            }
        }
        else if (collision.gameObject.CompareTag("Boss"))
        {
            Health -= B_ATK;
            slider.value = (float)Health / P_HP;
            if (Health <= 0)
            {
                Health = P_HP;
                slider.value = 1;
                died = true;
                transform.position = new Vector2(0, 1);
            }
        }
    }
}
