using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilMove : MonoBehaviour
{
    Rigidbody player;
    [SerializeField] float Speed;
    [SerializeField] float Multiplier;
    [SerializeField] float Tijd;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            gameObject.transform.position = new Vector3(transform.position.x - Speed * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(transform.position.x, Speed * 100 * Multiplier, transform.position.z);
        }
    }
}
