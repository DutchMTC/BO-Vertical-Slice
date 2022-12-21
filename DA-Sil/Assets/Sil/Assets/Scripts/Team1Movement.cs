using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team1Movement : MonoBehaviour
{
    // The Animator component that will be used to control the animation
    public Animator animator;

    void Update()
    {
        checkTeam1Movement();
    }

    private void checkTeam1Movement()
    {
        // Team 1
        if ((Input.GetKey(KeyCode.W)
            || Input.GetKey(KeyCode.A)
            || Input.GetKey(KeyCode.S)
            || Input.GetKey(KeyCode.D))
            &&
            (gameObject == GameObject.Find("Player1")
            || gameObject == GameObject.Find("Player2")
            || gameObject == GameObject.Find("Player3")))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}