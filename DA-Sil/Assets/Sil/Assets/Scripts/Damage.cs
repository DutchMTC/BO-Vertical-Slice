using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damage;
    private bool canTakeDamage;
    [SerializeField] private GameObject hitPrefab;
    private GameObject hitCanvas;

    void Start()
    {
        hitCanvas = GameObject.Find("Effect Canvas");
    }
    void Update()
    {
        if (gameObject.GetComponent<PickUp>().Distance2 <= 20 && GetComponent<BallMove>().thrownByRight == false)
        {
            Debug.Log("Distance1 = " + gameObject.GetComponent<PickUp>().Distance2);
            if (gameObject.GetComponent<PickUp>().isPickedUp == false)
            {
                if (GetComponent<BallMove>().isInAir == true)
                {
                    Debug.Log(damage);
                    GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.GetComponent<Health>().TakeDamage(damage);
                    GameObject hit = Instantiate(hitPrefab, hitCanvas.transform);
                    hit.transform.position = GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader2.transform.position + new Vector3(0, 75f, 0);
                    Destroy(hit, 0.3f);
                    GetComponent<BallMove>().isInAir = false;
                    GetComponent<BallMove>().countDown = 0.5f;
                    GetComponent<BallMove>().isInDelay = true;
                }
            }
        }
        if (gameObject.GetComponent<PickUp>().Distance1 <= 20 && GetComponent<BallMove>().thrownByRight == true)
        {
            Debug.Log("Distance2 = " + gameObject.GetComponent<PickUp>().Distance1);
            if (gameObject.GetComponent<PickUp>().isPickedUp == false)
            {
                if (GetComponent<BallMove>().isInAir == true)
                {
                    Debug.Log(damage);
                    GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.GetComponent<Health>().TakeDamage(damage);
                    GameObject hit = Instantiate(hitPrefab, hitCanvas.transform);
                    hit.transform.position = GameObject.Find("MovementController").GetComponent<FollowTheLeader>().leader1.transform.position + new Vector3(0, 75f, 0);
                    Destroy(hit, 0.3f);
                    GetComponent<BallMove>().isInAir = false;
                }
            }
        }


    }
}