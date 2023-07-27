using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Room;

public class RoomNum : MonoBehaviour
{
    public GameObject Player;
    public GameObject FirstNum;
    public GameObject SecondNum;
    public static int room;
    public Sprite[] numbers;
    void Start()
    {
        room = 1;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.transform.position = new Vector2(-38.2f, -17f);
            room++;
            UpdateRoom();
            Debug.Log(room);
        }
    }
    public void UpdateRoom()
    {
        //takes First and Second digit from number
        // int room is the current number of the floor
        int First = room / 10;
        int Second = room % 10;
        // accesses SpriteRenderer of gameobjects which hold the position for the numbers
        SpriteRenderer FirstSprite = FirstNum.GetComponent<SpriteRenderer>();
        SpriteRenderer SecondSprite = SecondNum.GetComponent<SpriteRenderer>();
        // updates the sprites
        if (room >= 10)
        {
            FirstSprite.sprite = numbers[First];
            SecondSprite.sprite = numbers[Second];
        }
        if (room < 10)
        {
            FirstSprite.sprite = numbers[0];
            SecondSprite.sprite = numbers[room];
        }
    }
}
