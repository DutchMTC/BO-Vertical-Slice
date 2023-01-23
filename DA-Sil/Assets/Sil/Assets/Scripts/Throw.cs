using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject ball;
    [SerializeField] private GameObject ballParent;
    public int PickedUp;
    void Start()
    {
        ballParent = GameObject.Find("BallCanvas");
    }


    void Update()
    {
        if (gameObject == GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1)
        {
            if (Input.GetKeyDown(KeyCode.K) && PickedUp > 0)
            {
                GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.GetComponent<Animator>().SetTrigger("ballThrow");
                PickedUp -= 1;

            }
        }

        if (gameObject == GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2)
        {
            if (Input.GetKeyDown(KeyCode.Backslash) && PickedUp > 0)
            {
                GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.GetComponent<Animator>().SetTrigger("ballThrow");
                PickedUp -= 1;
            }
        }

    }

    public void InstantiateBall(int thrower)
    {
        GameObject Thrown = Instantiate(ball, ballParent.transform);
        Thrown.GetComponent<BallMove>().thrower = thrower;
        if(thrower == 1)
        {
            Thrown.GetComponent<BallMove>().thrownByRight = false;
        }else if(thrower == 2)
        {
            Thrown.GetComponent<BallMove>().thrownByRight = true;
        }
        ball.GetComponent<BallMove>().isInAir = true;
    }
}