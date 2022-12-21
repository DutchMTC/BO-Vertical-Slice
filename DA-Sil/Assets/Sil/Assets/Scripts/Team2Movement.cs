using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team2Movement : MonoBehaviour
{
    // The Animator component that will be used to control the animation
    public Animator animator;

    void Update()
    {
        checkTeam2Movement();
    }

    private void checkTeam2Movement()
    {
        // Team 2
        if ((Input.GetKey(KeyCode.UpArrow)
            || Input.GetKey(KeyCode.DownArrow)
            || Input.GetKey(KeyCode.LeftArrow)
            || Input.GetKey(KeyCode.RightArrow))
            &&
            (gameObject == GameObject.Find("Player4")
            || gameObject == GameObject.Find("Player5")
            || gameObject == GameObject.Find("Player6")))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}