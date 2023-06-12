using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Base_stats;
using static HeartsCounter;
using TMPro;

public class Shopping : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public TextMeshProUGUI hpbuy;
    public TextMeshProUGUI atkbuy;
    private int hpcost;
    private int atkcost;
    public AudioSource click;
    public GameObject playerc;  
    void Start()
    {
        hpcost = 10;
        atkcost = 10;
    }
    public void BuyHP()
    {
        if (hearts >= hpcost)
        {
            click.Play();
            P_HP += 1;
            hearts -= hpcost;
            hpcost++;
            hpbuy.text = "Cost " + hpcost;
            Combat combatScript = playerc.GetComponent<Combat>();
            combatScript.Stats();
        }
    }
    public void BuyATK()
    {
        if (hearts >= atkcost)
        {
            click.Play();
            P_ATK += 1;
            hearts -= atkcost;
            atkcost++;
            atkbuy.text = "Cost " + atkcost;
            Combat combatScript = playerc.GetComponent<Combat>();
            combatScript.Stats();
        }
    }
    void Update()
    {
//        Debug.Log("costs: HP: " + hpcost + " ATK: " + atkcost + "hpbuy=" + hpbuy.text + "atkbuy=" + atkbuy.text);
        if (Input.GetKeyDown(KeyCode.Escape) && animator.GetBool("shop") == true)
        {
            click.Play();
            Exit();
        }
    }
    public void Exit()
    {
        click.Play();
        MovementScript movementScript = player.GetComponent<MovementScript>();
        movementScript.enabled = true;
        animator.SetBool("shop", false);
    }
}
