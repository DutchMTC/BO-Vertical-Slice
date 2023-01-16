using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BallMove : MonoBehaviour
{
    private GameObject leader1;
    private GameObject leader2;
    private GameObject movementController;
    public bool isInAir = true;
    public bool thrownByRight = true;
    internal int thrower;
    private Vector3 movementVector = Vector3.zero;
    public float moveSpeed;
    public PolygonCollider2D bounds;


    // Start is called before the first frame update
    void Start()
    {
        movementController = GameObject.Find("MovementController");

        leader1 = movementController.GetComponent<FollowTheLeader>().leader1;
        leader2 = movementController.GetComponent<FollowTheLeader>().leader2;

        bounds = GameObject.Find("PolygonCollider").GetComponent<PolygonCollider2D>();

        moveSpeed = 500f;

        if (thrower == 1)
        {
            transform.position = leader1.transform.position;
            movementVector = (leader2.transform.position - transform.position).normalized * moveSpeed;
        }
        else if (thrower == 2)
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
            transform.position += movementVector * Time.deltaTime;
        }

        if (!bounds.OverlapPoint(transform.position))
        {
            isInAir = false;
        }
    }
}