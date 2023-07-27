using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotBarrierrr : MonoBehaviour
{
    public GameObject GameObject;
    public Animator animator;
    void Update()
    {
        if ((Vector2)GameObject.transform.position == new Vector2(-4f, 3f))
        {
            transform.position = new Vector2(0f, 4f);
        }
        else
        {
            transform.position = new Vector2(1000f, 1000f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("SageShow", true);
    }
}