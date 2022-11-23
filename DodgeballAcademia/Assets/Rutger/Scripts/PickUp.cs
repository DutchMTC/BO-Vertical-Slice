using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int ballnumber = 0;
    public bool isBall = true;
    public bool isPickedUp = false;
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
            GameObject.Find("Player1").GetComponent<RutMove>().Distance1 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player1").transform.position);
            GameObject.Find("Player2").GetComponent<RutMove>().Distance1 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player2").transform.position);
            if (GameObject.Find("Player1").GetComponent<RutMove>().Distance1 >= 1)
            {
                if (isPickedUp == false)
                {
                    GameObject.Find("Player1").GetComponent<RutMove>().PickedUp.Add(gameObject);
                }
                isPickedUp = true;
            }
            if (GameObject.Find("Player2").GetComponent<RutMove>().Distance2 >= 1)
            {
                isPickedUp = true;
                GameObject.Find("Player2").GetComponent<RutMove>().PickedUp.Add(gameObject);
            }
        }

    }
}
