using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damage;


    void Update()
    {
        if (gameObject.GetComponent<PickUp>().Distance2 <= 20 && GetComponent<BallMove>().thrownByRight == false)
        {
            Debug.Log("Distance1" + gameObject.GetComponent<PickUp>().Distance2);
            if (gameObject.GetComponent<PickUp>().isPickedUp == false)
            {
                if (GetComponent<BallMove>().isInAir == true)
                {
                    Debug.Log(damage);
                    GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.GetComponent<Health>().TakeDamage(damage);
                    GetComponent<BallMove>().isInAir = false;
                }
            }
        }
        if (gameObject.GetComponent<PickUp>().Distance1 <= 20 && GetComponent<BallMove>().thrownByRight == true)
        {
            Debug.Log("Distance2" + gameObject.GetComponent<PickUp>().Distance1);
            if (gameObject.GetComponent<PickUp>().isPickedUp == false)
            {
                if (GetComponent<BallMove>().isInAir == true)
                {
                    Debug.Log(damage);
                    GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.GetComponent<Health>().TakeDamage(damage);
                    GetComponent<BallMove>().isInAir = false;
                }
            }
        }


    }
}