using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_stats : MonoBehaviour
{
    public static int P_HP;
    public static int P_ATK;
    public static int E_HP;
    public static int E_ATK;
    public static int B_ATK;
    public static int B_HP;
    public static int B_HP_M;
    void Awake()
    {
        P_HP = 200;
        P_ATK = 1500;
        E_HP = 50;
        E_ATK = 10;
        B_ATK = 15;
        B_HP = 400;
        B_HP_M = 1;
    }
    void Update()
    {
 //       Debug.Log("Player HP " + P_HP + "Player ATK " + P_ATK + "Enemy HP " + E_HP + "Enemy ATK " + E_ATK);
    }
 }
