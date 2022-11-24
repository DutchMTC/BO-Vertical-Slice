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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBall == true)
        {
            Distance1 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player1").transform.position);
            Distance2 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player2").transform.position);
            if (Distance1 <= 1)
            {
                if (isPickedUp == false)
                {
                    GameObject.Find("Player1").GetComponent<RutMove>().PickedUp.Add(gameObject);
                    gameObject.transform.position = new Vector3(1, 0, 0);
                    gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    gameObject.transform.parent = GameObject.Find("Player1").transform;
                }
                isPickedUp = true;
            }
            if (Distance2 <= 1)
            {
                if (isPickedUp == false)
                {
                    GameObject.Find("Player2").GetComponent<RutMove>().PickedUp.Add(gameObject);
                }
                isPickedUp = true;
            }
        }

    }
}
