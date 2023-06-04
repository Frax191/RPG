using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Base_stats;
using static Combat;
using static HeartsCounter;

public class Combat_Boss : MonoBehaviour
{
    private bool triggered;
    public GameObject musicPlayerObject;
    private int Health;
    private int Attack;
    public AudioSource GetHit;
    public AudioSource bossmusic;
    private bool bossactive;
    private MusicPlayer musicPlayer;
    public static bool openthedoor;
    public static bool defeated;

    void Start()
    {
        openthedoor = false;
        triggered = false;
        musicPlayer = musicPlayerObject.GetComponent<MusicPlayer>();
        bossactive = false;
        Stats();
    }

    public void Stats()
    {
        Health = B_HP;
        Attack = B_ATK;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        GetHit.Play();
        if (Health <= 0)
        {
            bossmusic.Stop();
            openthedoor = true;
            transform.position = new Vector2(1000f, 1000f);
            defeated = true;
            hearts += 30 * B_HP_M;
            Invoke("Stop", 1f); 
        }
    }

    void Update()
    {
        if (bossactive == true && triggered == false)
        {
            musicPlayer.TogglePause();
            Invoke("PlayBossMusic", 0.7f);
            triggered = true;
        }
        if (bossmusic.isPlaying == true && died == true)
        {
            bossmusic.Stop();
            musicPlayer.TogglePause();
            died = false;
        }
    }

    public void PlayBossMusic()
    {
        bossmusic.Play();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Bullet"))
        {
            bossactive = true;
        }
    }
    private void Stop()
    {
        musicPlayer.TogglePause();
        Destroy(gameObject);
    }
}
