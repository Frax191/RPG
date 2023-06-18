using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Base_stats;
using static Combat;
using static HeartsCounter;
using TMPro;
using UnityEngine.UI;

public class Combat_Boss : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI bossname;
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
    public Animator animator;

    void Start()
    {
        musicPlayer = musicPlayerObject.GetComponent<MusicPlayer>();
        Stats();
        slider.value = 1;
    }

    public void Stats()
    {
        Health = B_HP;
        Attack = B_ATK;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        slider.value = (float)Health / B_HP;
        GetHit.Play();
        if (Health <= 0)
        {
            bossmusic.Stop();
            openthedoor = true;
            transform.position = new Vector2(1000f, 1000f);
            animator.SetBool("Showbb", false);
            defeated = true;
            hearts += 50 * B_HP_M;
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
        if (other.CompareTag("Player") || other.CompareTag("Bullet") && bossactive == false)
        {
            bossname.text = "Unholy Spirit of the Grimghoul";
            animator.SetBool("Showbb", true);
            bossactive = true;
        }
    }
    private void Stop()
    {
        musicPlayer.TogglePause();
        Destroy(gameObject);
    }
}
