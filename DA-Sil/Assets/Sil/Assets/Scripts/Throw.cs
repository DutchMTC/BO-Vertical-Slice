using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    public int PickedUp;
    void Start()
    {

    }

    
    void Update()
    {
        if (gameObject == GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1)
        {
            if (Input.GetKeyDown(KeyCode.K) && PickedUp > 0)
            {
                GameObject Thrown = Instantiate(ball);
                Thrown.GetComponent<BallMove>().thrower = 1;
                Thrown.GetComponent<BallMove>().isInAir = true;
                Thrown.GetComponent<PickUp>().thrownByLeft = true;
                PickedUp -= 1;
            }
        }

        if (gameObject == GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2)
        {
            if (Input.GetKeyDown(KeyCode.Backslash) && PickedUp > 0)
            {
                GameObject Thrown = Instantiate(ball);
                Thrown.GetComponent<BallMove>().thrower = 2;
                Thrown.GetComponent<BallMove>().isInAir = true;
                Thrown.GetComponent<PickUp>().thrownByLeft = false;
                PickedUp -= 1;
            }
        }

    }
}
