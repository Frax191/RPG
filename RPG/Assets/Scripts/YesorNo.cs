using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Door1;
using static Door2;
using static Door3;
using static HeartsCounter;
using TMPro;
using static Barrier;
using static ShardScript1;
using static ShardScript2;
using static ShardScript3;

public class YesorNo : MonoBehaviour
{
    public static bool door1e;
    public static bool door2e;
    public static bool door3e;
    public Animator animator;
    public Animator animator2;
    public GameObject player;
    public AudioSource click;
    public EnemySpawner enemySpawner;
    public BossSpawner bossSpawner;
 /*   void Update()
    {
        Debug.Log("door1e " + door1e + "| door2e " + door2e + "| door3e " + door3e);
    }*/
    public void Start()
    {
        enemySpawner = GameObject.FindObjectOfType<EnemySpawner>();
        bossSpawner = GameObject.FindObjectOfType<BossSpawner>();
    }
    public void Yes()
    {
        click.Play();
        if (door1 == true)
        {
            player.transform.position = new Vector2(-90f, -57f);
            animator.SetBool("DoorOpen", false);
            animator2.SetBool("DifficultyShow", false);
            MovementScript movementScript = player.GetComponent<MovementScript>();
            movementScript.enabled = true;
            door1 = false;
            door1e = true;
            enemySpawner.SpawnEnemies();
            bossSpawner.SpawnEnemy();
        }
        if (door2 == true)
        {
            player.transform.position = new Vector2(-26f, -48f);
            animator.SetBool("DoorOpen", false);
            animator2.SetBool("DifficultyShow", false);
            MovementScript movementScript = player.GetComponent<MovementScript>();
            movementScript.enabled = true;
            door2 = false;
            door2e = true;
            Debug.Log("Frax");
            Reset();
            Debug.Log("Frax");
            enemySpawner.SpawnEnemies();
            Debug.Log("Frax");
            bossSpawner.SpawnEnemy();
        }
        if (door3 == true)  
        {
            player.transform.position = new Vector2(-96f, -8f);
            animator.SetBool("DoorOpen", false);
            animator2.SetBool("DifficultyShow", false);
            MovementScript movementScript = player.GetComponent<MovementScript>();
            movementScript.enabled = true;
            door3 = false;
            door3e = true;
            enemySpawner.SpawnEnemies();
            bossSpawner.SpawnEnemy();
        }
    }

    public void No()
    {
        click.Play();
        animator.SetBool("DoorOpen", false);
    }
    public void Reset()
    {
        shards = 0;
        trigger1 = false;
        trigger2 = false;
        trigger3 = false;
    }
}