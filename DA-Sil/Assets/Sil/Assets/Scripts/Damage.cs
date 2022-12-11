using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damage;
    

    void Update()
    {
        if (gameObject.GetComponent<PickUp>().Distance1 <= 1)
        {
            if (gameObject.GetComponent<PickUp>().isPickedUp == false && gameObject.GetComponent<PickUp>().thrownByLeft == false)
            {
                if (GetComponent<BallMove>().isInAir == true)
                {
                    GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.GetComponent<Health>().TakeDamage(damage);
                    GetComponent<BallMove>().isInAir = false;
                }
            }
        }
        if (gameObject.GetComponent<PickUp>().Distance4 <= 1)
        {
            if (gameObject.GetComponent<PickUp>().isPickedUp == false && gameObject.GetComponent<PickUp>().thrownByLeft == true)
            {
                if (GetComponent<BallMove>().isInAir == true)
                {
                    GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.GetComponent<Health>().TakeDamage(damage);
                    GetComponent<BallMove>().isInAir = false;
                }                
            }
        }
    }
}
