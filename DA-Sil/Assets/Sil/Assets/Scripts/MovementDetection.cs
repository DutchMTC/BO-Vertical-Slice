using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDetection : MonoBehaviour
{
    // The Animator component that will be used to control the animation
    public Animator animator;

    // The previous position of the object
    private Vector3 previousPosition;

    void Start()
    {
        // Store the initial position of the object
        previousPosition = transform.position;
    }

    void Update()
    {
        // Check if the object's position has changed
        if (transform.position != previousPosition)
        {
            // If the animation is not already playing, play the animation
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("OttoWalk"))
            {
                animator.Play("OttoWalk");
            }
        }
        else
        {
            // If the position has not changed, stop the animation
            animator.StopPlayback();
        }

        // Store the current position for the next frame
        previousPosition = transform.position;
    }
}
