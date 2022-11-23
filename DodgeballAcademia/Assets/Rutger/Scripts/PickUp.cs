using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool isBall = true;

    public List<bool> CanPickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Player1").GetComponent<RutMove>().Distance1 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player1").transform.position);
        GameObject.Find("Player2").GetComponent<RutMove>().Distance1 = Vector3.Distance(gameObject.transform.position, GameObject.Find("Player2").transform.position);
        if (GameObject.Find("Player2").GetComponent<RutMove>().Distance1 >= 1)
        {
            CanPickUp[0] = true;
        }
        if (Distance2 >= 1)
        {
            CanPickUp[1] = true;
        }
    }
}
