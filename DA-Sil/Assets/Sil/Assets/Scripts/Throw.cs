using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject ball;
    [SerializeField] private GameObject ballParent;
    [SerializeField] private Animator playerAnim;
    private GameObject movementController;
    private int thrower;
    public int PickedUp;
    void Start()
    {
        ballParent = GameObject.Find("BallCanvas");
        movementController = GameObject.Find("MovementController");
    }


    void Update()
    {
        if (gameObject == GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1)
        {
            if (Input.GetKeyDown(KeyCode.K) && PickedUp > 0)
            {
                thrower = 1;
                movementController.GetComponent<SilMove>().freeze1();
                playerAnim.SetTrigger("ballThrow");

            }
        }

        if (gameObject == GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2)
        {
            if (Input.GetKeyDown(KeyCode.Backslash) && PickedUp > 0)
            {
                thrower = 2;
                movementController.GetComponent<SilMove>().freeze2();
                playerAnim.SetTrigger("ballThrow");
            }
        }

    }

    public void instantiateBall()
    {
        GameObject ballThrown = Instantiate(ball, ballParent.transform);
        ballThrown.GetComponent<BallMove>().thrower = thrower;
        ball.GetComponent<BallMove>().isInAir = true;
        ballThrown.GetComponent<BallMove>().thrownByRight = false;
        PickedUp -= 1;
    }
}