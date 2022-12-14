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
        // Initialize the previous position to the current position
        previousPosition = transform.position;
    }

    void Update()
    {
        // Check if the position has changed since the previous frame
        bool isMoving = (transform.position != previousPosition);

        // Only set the "isMoving" parameter if the value has changed
        if (animator.GetBool("isWalking") != isMoving)
        {
            animator.SetBool("isWalking", isMoving);
        }

        // Store the current position for the next frame
        previousPosition = transform.position;
    }
}