using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BallMove : MonoBehaviour
{
    private GameObject leader1;
    private GameObject leader2;
    private GameObject movementController;
    private GameObject throwManager;

    private Vector3 movementVector = Vector3.zero;
    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        movementController = GameObject.Find("MovementController");
        throwManager = GameObject.Find("ThrowManager");
        leader1 = movementController.GetComponent<FollowTheLeader>().leader1;
        leader2 = movementController.GetComponent<FollowTheLeader>().leader2;

        moveSpeed = 7f;

        if (throwManager.GetComponent<Throw>().thrower == 1)
        {
            transform.position = leader1.transform.position;
            movementVector = (leader2.transform.position - transform.position).normalized * moveSpeed;
        }
        else if(throwManager.GetComponent<Throw>().thrower == 2)
        {
            transform.position = leader2.transform.position;
            movementVector = (leader1.transform.position - transform.position).normalized * moveSpeed;
        }


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movementVector * Time.deltaTime;
    }
}
