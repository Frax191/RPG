using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startbutton : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject player;
    void Start()
    {
        player.SetActive(false);
    }
    public void startbutton()
    {
        parentObject.SetActive(false);
        player.SetActive(true);
    }
}
