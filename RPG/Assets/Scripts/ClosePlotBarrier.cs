using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePlotBarrier : MonoBehaviour
{
    public Animator animator;
    public AudioSource click;
    public void CloseBarrier()
    {
        animator.SetBool("SageShow", false);
        click.Play();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            CloseBarrier();
        }
    }
}