using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilMove : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float Multiplier;
    [SerializeField] float Height;
    [SerializeField] float Tijd;
    [SerializeField] bool isJumping;
    [SerializeField] bool isJumpingDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && gameObject.GetComponent<FollowTheLeader>().ts1[0] == gameObject) {gameObject.transform.position = new Vector3(transform.position.x - Speed * Time.deltaTime, transform.position.y, transform.position.z);}
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.GetComponent<FollowTheLeader>().Leader2 == 0) {gameObject.transform.position = new Vector3(transform.position.x - Speed * Time.deltaTime, transform.position.y, transform.position.z);}

        if (Input.GetKey(KeyCode.D) && gameObject.GetComponent<FollowTheLeader>().ts1[0] == gameObject) {gameObject.transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);}
        if (Input.GetKey(KeyCode.RightArrow) && gameObject.GetComponent<FollowTheLeader>().Leader2 == 0) {gameObject.transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);}

        if (Input.GetKey(KeyCode.S) && gameObject.GetComponent<FollowTheLeader>().ts1[0] == gameObject) {gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Speed * Time.deltaTime);}
        if (Input.GetKey(KeyCode.DownArrow) && gameObject.GetComponent<FollowTheLeader>().Leader2 == 0) {gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Speed * Time.deltaTime);}


        if (Input.GetKey(KeyCode.W) && gameObject.GetComponent<FollowTheLeader>().ts1[0] == gameObject) {gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Speed * Time.deltaTime);}
        if (Input.GetKey(KeyCode.UpArrow) && gameObject.GetComponent<FollowTheLeader>().Leader2 == 0) {gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Speed * Time.deltaTime);}

        if (isJumping == true)
        {
            Tijd += Time.deltaTime + Time.deltaTime + Time.deltaTime + Time.deltaTime + Time.deltaTime;
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Tijd) * Height, transform.position.z);
            if (Tijd >= 3.2f)
            {
                Tijd = 0;
                isJumping = false;
                transform.position = new Vector3(transform.position.x, Mathf.Sin(Tijd) * Height, transform.position.z);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && gameObject.GetComponent<FollowTheLeader>().Leader1 == 0)
            {
                isJumping = true;
            }
            if (Input.GetKeyDown(KeyCode.RightShift) && gameObject.GetComponent<FollowTheLeader>().Leader2 == 0)
            {
                isJumping = true;
            }
        }
    }
}
