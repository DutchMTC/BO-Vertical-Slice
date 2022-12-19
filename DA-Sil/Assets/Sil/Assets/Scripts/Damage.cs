using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damage;
    

    void Update()
    {
        if (GetComponent<PickUp>().Distance1 <= 1)
        {
            if (gameObject.GetComponent<PickUp>().isPickedUp == false)
            {
                if (GetComponent<BallMove>().isInAir == true && GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1)
                {
                    GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.GetComponent<Health>().TakeDamage(damage);
                    GetComponent<BallMove>().isInAir = false;
                }
            }
        }
        if (gameObject.GetComponent<PickUp>().Distance2 <= 1)
        {
            if (gameObject.GetComponent<PickUp>().isPickedUp == false)
            {
                if (GetComponent<BallMove>().isInAir == true)
                {
                    GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.GetComponent<Health>().TakeDamage(damage);
                    GetComponent<BallMove>().isInAir = false;
                }                
            }
        }
    }
}
