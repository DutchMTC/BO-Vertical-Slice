using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(transform.position.x - 1f * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(transform.position.x + 1f * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f * Time.deltaTime);
        }
    }
}
