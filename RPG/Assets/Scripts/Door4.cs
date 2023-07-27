using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Combat_Boss;
using static YesorNo;
using static Unlocking;

public class Door4 : MonoBehaviour
{
    public static bool beatgame;
    private int completed;
    public GameObject Player;
    private bool trigger1;
    private bool trigger2;
    private bool trigger3;
    private bool trigger4;
    private bool trigger5;
    private bool trigger6;
    private bool trigger7;
    private bool trigger8;
    private bool trigger9;
    void Start()
    {
        completed = 0;
    }
    void Update()
    {
        if (openthedoor == true)
        {
            if (door1e == true)
            {
                transform.position = new Vector2(-93f, -46f);
            }
            if (door2e == true)
            {
                transform.position = new Vector2(-26f, -32f);
            }
            if (door3e == true)
            {
                transform.position = new Vector2(-85f, 0f);
            }
        }
        if (openthedoor == false)
        {
            transform.position = new Vector2(1000f, 1000f);
        }
        if (completed == 9)
        {
            beatgame = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.transform.position = new Vector2(0f, 1f);
            openthedoor = false;
            Combat combatScript = Player.GetComponent<Combat>();
            combatScript.Stats();
            if (door1e == true)
            {
                if (cdiff == 1 && !trigger1)
                {
                    completed++;
                    trigger1 = true;
                }
                if (cdiff == 2 && !trigger2)
                {
                    completed++;
                    trigger2 = true;
                }
                if (cdiff == 3 && !trigger3)
                {
                    completed++;
                    trigger3 = true;
                }
            }
            else if (door2e == true)
            {
                if (cdiff == 1 && !trigger4)
                {
                    completed++;
                    trigger4 = true;
                }
                if (cdiff == 2 && !trigger5)
                {
                    completed++;
                    trigger5 = true;
                }
                if (cdiff == 3 && !trigger6)
                {
                    completed++;
                    trigger6 = true;
                }
            }
            else if (door3e == true)
            {
                if (cdiff == 1 && !trigger7)
                {
                    completed++;
                    trigger7 = true;
                }
                if (cdiff == 2 && !trigger8)
                {
                    completed++;
                    trigger8 = true;
                }
                if (cdiff == 3 && !trigger9)
                {
                    completed++;
                    trigger9 = true;
                }
            }
            doorfalse();
        }
    }
    public void doorfalse()
    {
        door1e = false;
        door2e = false;
        door3e = false;
    }
}
