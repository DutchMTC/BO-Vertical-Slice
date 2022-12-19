using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int ballnumber = 0;
    public bool isBall = true;
    public bool isPickedUp = false;
    public float Distance1 = 1;
    public float Distance2 = 1;
    public List<bool> CanPickUp;

    private GameObject leader1;
    private GameObject leader2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        leader1 = GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1;
        leader2 = GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2;

        Distance1 = Vector2.Distance(gameObject.transform.position, new Vector2(leader1.transform.position.x, leader1.transform.position.y - 60f));
        Distance2 = Vector2.Distance(gameObject.transform.position, new Vector2(leader2.transform.position.x, leader2.transform.position.y - 60f));

        if (isBall == true)
        {
            if (gameObject.GetComponent<BallMove>().isInAir == false && Distance1 <= 40 && isPickedUp == false && GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1)
            {
                GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.GetComponent<Throw>().PickedUp += 1;
                Destroy(gameObject);
            }

            if (GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2 && Distance2 <= 30 && isPickedUp == false)
            {
                GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.GetComponent<Throw>().PickedUp += 1;
                Destroy(gameObject);
            }

        }
    }
}
