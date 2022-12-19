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
    public bool isInAir = true;
    internal int thrower;
    private Vector3 movementVector = Vector3.zero;
    public float moveSpeed;

    Vector3 minPosition = new Vector3(-11.5f, 0f, -7f);
    Vector3 maxPosition = new Vector3(11.5f, 10f, 7f);
    bool isIn = true;

    // Start is called before the first frame update
    void Start()
    {
        movementController = GameObject.Find("MovementController");
        throwManager = GameObject.Find("ThrowManager");
        leader1 = movementController.GetComponent<FollowTheLeader>().leader1;
        leader2 = movementController.GetComponent<FollowTheLeader>().leader2;

        moveSpeed = 7f;

        if (thrower == 1)
        {
            transform.position = leader1.transform.position;
            movementVector = (leader2.transform.position - transform.position).normalized * moveSpeed;
        }
        else if(thrower == 2)
        {
            transform.position = leader2.transform.position;
            movementVector = (leader1.transform.position - transform.position).normalized * moveSpeed;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (isInAir == true) 
        { 
            for (int i = 0 ; i < 3 && isIn; ++i )
            {
                if (transform.position[i] < minPosition[i] || transform.position[i] > maxPosition[i])
                {
                    isIn = false;
                }
            }

            if (isIn)
            {
                Debug.Log("The ball is inside of the area");
                transform.position += movementVector * Time.deltaTime;
            }
            else
            {
                Debug.Log("The ball is outside of the area");
                isInAir = false;
            }
        }
    }
}
