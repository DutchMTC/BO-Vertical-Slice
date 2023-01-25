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
    public bool isInDelay = true;
    public bool thrownByRight = true;
    private bool canBeFrozen = false;
    internal int thrower;
    public float countDown = 1;
    private Vector3 movementVector = Vector3.zero;
    public float moveSpeed;
    public PolygonCollider2D bounds;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NoFreeze());

        movementController = GameObject.Find("MovementController");

        leader1 = movementController.GetComponent<FollowTheLeader>().leader1;
        leader2 = movementController.GetComponent<FollowTheLeader>().leader2;

        bounds = GameObject.Find("BallCollider").GetComponent<PolygonCollider2D>();

        moveSpeed = 700f;

        if (thrower == 1)
        {
            transform.position = new Vector3(leader1.transform.position.x, leader1.transform.position.y + 60, leader1.transform.position.z);
            movementVector = (new Vector3(leader2.transform.position.x, leader2.transform.position.y + 60, leader2.transform.position.z) - transform.position).normalized * moveSpeed;
        }
        else if (thrower == 2)
        {
            transform.position = new Vector3(leader2.transform.position.x, leader2.transform.position.y + 60, leader2.transform.position.z);
            movementVector = (new Vector3(leader1.transform.position.x, leader1.transform.position.y + 60, leader1.transform.position.z) - transform.position).normalized * moveSpeed;
            transform.Rotate(0, 180, 0);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (countDown > 0)
            countDown -= Time.deltaTime;
        if (countDown <= 0)
            isInDelay = false;
        if (isInAir == true)
        {
            transform.position += movementVector * Time.deltaTime;
        }

        if (!bounds.OverlapPoint(transform.position) && canBeFrozen)
        {
            isInAir = false;
        }
    }

    IEnumerator NoFreeze()
    {
        yield return new WaitForSeconds(1);
        canBeFrozen = true;
    }
}