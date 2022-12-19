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
                GameObject ballThrown = Instantiate(ball, ballParent.transform);
                ballThrown.GetComponent<BallMove>().thrower = 1;
                ball.GetComponent<BallMove>().isInAir = true;
                PickedUp -= 1;
            }
        }

        if (gameObject == GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2)
        {
            if (Input.GetKeyDown(KeyCode.Backslash) && PickedUp > 0)
            {
                GameObject Thrown = Instantiate(ball, ballParent.transform);
                Thrown.GetComponent<BallMove>().thrower = 2;
                ball.GetComponent<BallMove>().isInAir = true;
                PickedUp -= 1;
            }
        }

    }
}
