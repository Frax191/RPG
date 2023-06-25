using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Combat_Boss;
using static YesorNo;

public class Door4 : MonoBehaviour
{

    public GameObject Player;
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
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.transform.position = new Vector2(0f, 1f);
            openthedoor = false;
            Combat combatScript = Player.GetComponent<Combat>();
            combatScript.Stats();
            door1e = false;
            door2e = false;
            door3e = false;
        }
    }
}
