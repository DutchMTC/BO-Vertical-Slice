using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Team2Movement : MonoBehaviour
{
    // The Animator component that will be used to control the animation
    public Animator animator;
    private GameObject movementController;
    public PolygonCollider2D bounds;

    void Start()
    {
        movementController = GameObject.Find("MovementController");
    }

    void Update()
    {
        if(movementController.GetComponent<SilMove>().canMove2 == true)
        {
            checkTeam2Movement();
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (!bounds.OverlapPoint(transform.position))
        {
            // If it is, move the gameobject back inside the bounds of the collider.
            transform.position = bounds.ClosestPoint(transform.position);
        }
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