using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_stats : MonoBehaviour
{
    public static int P_HP;
    public static int P_ATK;
    public static int E_HP;
    public static int E_ATK;
    public static int E_HP_M;
    public static int E_ATK_M;
    public static int B_ATK;
    public static int B_ATK_M;
    public static int B_HP;
    public static int B_HP_M;
    void Awake()
    {
        P_HP = 200;
        P_ATK = 15;
        E_HP = 50;
        E_ATK = 10;
        E_HP_M = 1;
        E_ATK_M = 1;
        B_ATK = 15;
        B_HP = 4;
        B_HP_M = 1;
        B_ATK_M = 1;
    }
    void Update()
    {
        E_HP = (E_HP * E_HP_M);
        E_ATK = (E_ATK * E_ATK_M);
        B_ATK = (B_ATK * B_ATK_M);
        B_HP = (B_HP * B_HP_M);
    }
}
