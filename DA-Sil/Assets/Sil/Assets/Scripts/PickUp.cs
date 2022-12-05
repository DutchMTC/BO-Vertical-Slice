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
    public float Distance3 = 1;
    public float Distance4 = 1;
    public float Distance5 = 1;
    public float Distance6 = 1;
    public List<bool> CanPickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBall == false) 
        {

        }
        if (isBall == true)
        {
            if(gameObject.GetComponent<BallMove>().isInAir == false)
            {
                Distance1 = Vector3.Distance(gameObject.transform.position, GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.transform.position);
                //Distance1 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player1").transform.position);
                Distance2 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player2").transform.position);
                Distance3 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player3").transform.position);
                Distance4 = Vector3.Distance(gameObject.transform.position, GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.transform.position);
                //Distance4 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player4").transform.position);
                Distance5 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player5").transform.position);
                Distance6 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player6").transform.position);
                if (Distance1 <= 1)
                {
                    if (isPickedUp == false)
                    {
                        if (GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1)
                        {
                            GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.GetComponent<Throw>().PickedUp += 1;
                            Destroy(gameObject);
                        }
                    }
                    //isPickedUp = true;
                }
                /*
                if (Distance2 <= 1)
                {
                    if (isPickedUp == false)
                    {
                        if (GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1 == GameObject.Find("Player2"))
                        {
                            GameObject.Find("Player2").GetComponent<Throw>().PickedUp += 1;
                            Destroy(gameObject);
                        }
                    }
                    //isPickedUp = true;
                }
                if (Distance3 <= 1)
                {
                    if (isPickedUp == false)
                    {
                        if (GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1 == GameObject.Find("Player3"))
                        {
                            GameObject.Find("Player3").GetComponent<Throw>().PickedUp += 1;
                            Destroy(gameObject);
                        }
                    }
                    //isPickedUp = true;
                }
                */
                if (Distance4 <= 1)
                {
                    if (isPickedUp == false)
                    {
                        if (GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2)
                        {
                            GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.GetComponent<Throw>().PickedUp += 1;
                            Destroy(gameObject);
                        }
                    }
                }
                    //isPickedUp = true;
                /*
                }
                if (Distance5 <= 1)
                {
                    if (isPickedUp == false)
                    {
                        if (GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2 == GameObject.Find("Player5"))
                        {
                            GameObject.Find("Player5").GetComponent<Throw>().PickedUp += 1;
                            Destroy(gameObject);
                        }
                    }
                    //isPickedUp = true;
                }
                if (Distance6 <= 1)
                {
                    if (isPickedUp == false)
                    {
                        if (GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2 == GameObject.Find("Player6"))
                        {
                            GameObject.Find("Player6").GetComponent<Throw>().PickedUp += 1;
                            Destroy(gameObject);
                        }
                    }
                    //isPickedUp = true;
                }*/
            }
        }
    }
}
