using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static RoomNum;

public class floorbutton : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public AudioSource click;
    public GameObject RoomUpdate;
    public void button1()
    {
        room = 1;
        button();
    }
    public void button2()
    {
        if (beaten == 1)
        {
            room = 25;
            button(); 
        }
    }
    public void button3()
    {
        if (beaten == 2)
        {
            room = 50;
            button();
        }
    }
    public void button4()
    {
        if (beaten == 3)
        {
            room = 75;
            button();
        }
    }
    public void button()
    {
        animator.SetBool("FloorSelector", false);
        click.Play();
        player.transform.position = new Vector2(-38.2f, -17f);
        RoomNum RoomNumScript = RoomUpdate.GetComponent<RoomNum>();
        RoomNumScript.UpdateRoom();
        MovementScript movementScript = player.GetComponent<MovementScript>();
        movementScript.enabled = true;
    }
}
