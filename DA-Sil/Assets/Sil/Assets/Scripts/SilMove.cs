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
    [SerializeField] internal bool canMove1;
    [SerializeField] internal bool canMove2;

    [SerializeField] Animator walkAnimator;

    private GameObject leader1;
    private GameObject leader2;

    // Start is called before the first frame update
    void Start()
    {
        canMove1 = true;
        canMove2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(canMove1);

        leader1 = gameObject.GetComponent<FollowTheLeader>().leader1;
        leader2 = gameObject.GetComponent<FollowTheLeader>().leader2;

        // Leader1 Movement
        if (canMove1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                leader1.transform.position = new Vector3(leader1.transform.position.x, leader1.transform.position.y + Speed * Time.deltaTime, leader1.transform.position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                leader1.transform.position = new Vector3(leader1.transform.position.x - Speed * Time.deltaTime, leader1.transform.position.y, leader1.transform.position.z);
                //walkAnimator.SetBool("isWalking", true);
            }
            if (Input.GetKey(KeyCode.S))
            {
                leader1.transform.position = new Vector3(leader1.transform.position.x, leader1.transform.position.y - Speed * Time.deltaTime, leader1.transform.position.z);
                //walkAnimator.SetBool("isWalking", true);
            }
            if (Input.GetKey(KeyCode.D))
            {
                leader1.transform.position = new Vector3(leader1.transform.position.x + Speed * Time.deltaTime, leader1.transform.position.y, leader1.transform.position.z);
                //walkAnimator.SetBool("isWalking", true);
            }
        }
        if(Input.GetKeyUp(KeyCode.W)|| Input.GetKeyUp(KeyCode.A)|| Input.GetKeyUp(KeyCode.S)|| Input.GetKeyUp(KeyCode.D))
        {
            //walkAnimator.SetBool("isWalking", false);
        }

        // Leader2 Movement
        if (canMove2)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                leader2.transform.position = new Vector3(leader2.transform.position.x, leader2.transform.position.y + Speed * Time.deltaTime, leader2.transform.position.z);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                leader2.transform.position = new Vector3(leader2.transform.position.x - Speed * Time.deltaTime, leader2.transform.position.y, leader2.transform.position.z);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                leader2.transform.position = new Vector3(leader2.transform.position.x, leader2.transform.position.y - Speed * Time.deltaTime, leader2.transform.position.z);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                leader2.transform.position = new Vector3(leader2.transform.position.x + Speed * Time.deltaTime, leader2.transform.position.y, leader2.transform.position.z);
            }
        }


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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isJumping = true;
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                isJumping = true;
            }
        }
    }
    
    public void freeze1()
    {
        StartCoroutine(FreezeTeam1());
    }

    public void freeze2()
    {
        StartCoroutine(FreezeTeam2());
    }

    IEnumerator FreezeTeam1()
    {
        canMove1 = false;
        yield return new WaitForSeconds(0.5f);
        canMove1 = true;
    }

    IEnumerator FreezeTeam2()
    {
        canMove2 = false;
        yield return new WaitForSeconds(0.5f);
        canMove2 = true;
    }
}
