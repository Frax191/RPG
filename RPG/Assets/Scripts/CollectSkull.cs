using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSkull : MonoBehaviour
{
    public static bool skulls;
    public AudioSource pickup;
    void Start()
    {
        skulls = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        transform.position = new Vector2(1000, 1000);
        skulls = true;
        pickup.Play();
    }
}
