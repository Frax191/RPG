using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static Door1;
using static Door2;
using static Door3;
using static HeartsCounter;
using static Base_stats;
using static YesorNo;

public class Unlocking : MonoBehaviour
{
    private bool door1_1;
    private bool door1_2;
    private bool door1_3;
    private bool door2_1;
    private bool door2_2;
    private bool door2_3;
    private bool door3_1;
    private bool door3_2;
    private bool door3_3;
    public Animator animator;
    public GameObject Cover1;
    public GameObject Cover2;
    public GameObject Cover3;
    public Text Text1;
    public Text Text2;
    public Text Text3;
    public AudioSource click;
    public static int cdiff;

    void Start()
    {
        cdiff = 0;
        door1_1 = false;
        door1_2 = false;
        door1_3 = false;
        door2_1 = false;
        door2_2 = false;
        door2_3 = false;
        door3_1 = false;
        door3_2 = false;
        door3_3 = false;
    }

    void Update()
    {
        if (door1 == true)
        {
            Text1.text = "COST 10";
            Text2.text = "COST 150";
            Text3.text = "COST 250";
        }
        if (door2 == true)
        {
            Text1.text = "COST 100";
            Text2.text = "COST 200";
            Text3.text = "COST 500";
        }
        if (door3 == true)
        {
            Text1.text = "COST 1000";
            Text2.text = "COST 1300";
            Text3.text = "COST 1600";
        }
        if (door1 == true)
        {
            if (door1_1 == true)
            {
                Cover1.SetActive(false);
            }
            if (door1_2 == true)
            {
                Cover2.SetActive(false);
            }

            if (door1_3 == true)
            {
                Cover3.SetActive(false);
            }
        }
        else if (door2 == true)
        {
            if (door2_1 == true)
            {
                Cover1.SetActive(false);
            }
            if (door2_2 == true)
            {
                Cover2.SetActive(false);
            }

            if (door2_3 == true)
            {
                Cover3.SetActive(false);
            }
        }
        else if (door3 == true)
        {
            if (door3_1 == true)
            {
                Cover1.SetActive(false);
            }

            if (door3_2 == true)
            {
                Cover2.SetActive(false);
            }

            if (door3_3 == true)
            {
                Cover3.SetActive(false);
            }
        }
    }

    public void ButtonOne()
    {
        E_HP = 75;
        E_ATK = 15;
        B_ATK = 20;
        B_HP = 300;
        B_HP_M = 1;
        cdiff = 1;
        EBS();
        click.Play();
        if (door1 == true && hearts >= 10 && door1_1 == false)
        {
            hearts -= 10;
            door1_1 = true;
        }
        else if (door1 == true && door1_1 == true)
        {
            animator.SetBool("DoorOpen", true);

        }
        if (door2 == true && hearts >= 100 && door2_1 == false)
        {
            hearts -= 100;
            door2_1 = true;
        }
        else if (door2 == true && door2_1 == true)
        {   
            animator.SetBool("DoorOpen", true);
        }
        if (door3 == true && hearts >= 1000 && door3_1 == false)
        {
            hearts -= 1000;
            door3_1 = true;
        }
        else if (door3 == true && door3_1 == true)
        {
            animator.SetBool("DoorOpen", true);
        }
    }

    public void ButtonTwo()
    {
        E_HP = 150;
        E_ATK = 30;
        B_ATK = 40;
        B_HP = 600;
        B_HP_M = 2;
        cdiff = 2;
        EBS();
        click.Play();
        if (door1 == true && hearts >= 150 && door1_2 == false)
        {
            hearts -= 150;
            door1_2 = true;
        }
        else if (door1 == true && door1_2 == true)
        {
            animator.SetBool("DoorOpen", true);
        }
        if (door2 == true && hearts >= 200 && door2_2 == false)
        {
            hearts -= 200;
            door2_2 = true;
        }
        else if (door2 == true && door2_2 == true)
        {
            animator.SetBool("DoorOpen", true);
        }
        if (door3 == true && hearts >= 1300 && door3_2 == false)
        {
            hearts -= 1300;
            door3_2 = true;
        }
        else if (door3 == true && door3_2 == true)
        {
            animator.SetBool("DoorOpen", true);
        }
    }

    public void ButtonThree()
    {
        E_HP = 225;
        E_ATK = 40;
        B_ATK = 60;
        B_HP = 900;
        B_HP_M = 3;
        cdiff = 3;
        EBS();
        click.Play();
        if (door1 == true && hearts >= 250 && door1_3 == false)
        {
            hearts -= 250;
            door1_3 = true;
        }
        else if (door1 == true && door1_3 == true)
        {
            animator.SetBool("DoorOpen", true);
        }
        if (door2 == true && hearts >= 500 && door2_3 == false)
        {
            hearts -= 500;
            door2_3 = true;
        }
        else if (door2 == true && door2_3 == true)
        {
            animator.SetBool("DoorOpen", true);
        }
        if (door3 == true && hearts >= 1600 && door3_3 == false)
        {
            hearts -= 1600;
            door3_3 = true;
        }
        else if (door3 == true && door3_3 == true)
        {
            animator.SetBool("DoorOpen", true);
        }
    }
    void EBS()
    {
        int currentdoor = door1e ? 1 : (door2e ? 2 : (door3e ? 3 : 1));
        E_HP = E_HP * currentdoor;
        E_ATK = E_ATK * currentdoor;
        B_HP = B_HP * currentdoor;
        B_ATK = B_ATK * currentdoor;
    }
}
