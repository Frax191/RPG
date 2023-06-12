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
            transform.position = new Vector2(-93f, -46f);
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
            door1e = false;
            door2e = false;
            door3e = false;
        }
    }
}
