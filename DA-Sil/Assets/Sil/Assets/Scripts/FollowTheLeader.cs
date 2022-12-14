using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheLeader : MonoBehaviour
{
    [SerializeField] private float specSpeed;

    public Vector3 Distance = new Vector3();

    public GameObject leader1;
    public GameObject nextLeader1;
    public int leader1Index;

    public GameObject leader2;
    public GameObject nextLeader2;
    public int leader2Index;


    public List<GameObject> ts1 = new List<GameObject>();
    public List<GameObject> ts2 = new List<GameObject>();
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    public GameObject player6;

    private Transform leader1Pos;
    private Transform leader2Pos;

    void Start()
    {

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");
        player5 = GameObject.Find("Player5");
        player6 = GameObject.Find("Player6");

        specSpeed = 100f * Time.deltaTime;

        leader1 = player1;
        leader2 = player4;
    }

    void Update()
    {

        leader1Pos = leader1.transform;
        leader2Pos = leader2.transform;

        // Leader 1
        if(leader1Index == 0)
        {
            leader1 = player1;
        }else if(leader1Index == 1)
        {
            leader1 = player2;
        }else if(leader1Index == 2)
        {
            leader1 = player3;
        }else if(leader1Index == 3)
        {
            leader1Index = 0;
        }

        if(leader1 == player1)
        {
            nextLeader1 = player2;
        }else if(leader1 == player2)
        {
            nextLeader1 = player3;
        }
        else if (leader1 == player3)
        {
            nextLeader1 = player1;
        }

        if (leader2 == player4)
        {
            nextLeader2 = player5;
        }
        else if (leader2 == player5)
        {
            nextLeader2 = player6;
        }
        else if (leader2 == player6)
        {
            nextLeader2 = player4;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            leader1Index++;
        }

        if(leader1 == player1)
        {
            StartCoroutine(followLeader1Above(player2));
            StartCoroutine(followLeader1Below(player3));
            player1.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            player2.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            player3.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
        }
        else if(leader1 == player2)
        {
            StartCoroutine(followLeader1Above(player3));
            StartCoroutine(followLeader1Below(player1));
            player1.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            player2.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            player3.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
        }
        else if (leader1 == player3)
        {
            StartCoroutine(followLeader1Above(player1));
            StartCoroutine(followLeader1Below(player2));
            player1.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            player2.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            player3.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
        }

        // Leader 2
        if (leader2Index == 0)
        {
            leader2 = player4;
        }
        else if (leader2Index == 1)
        {
            leader2 = player5;
        }
        else if (leader2Index == 2)
        {
            leader2 = player6;
        }
        else if (leader2Index == 3)
        {
            leader2Index = 0;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            leader2Index++;
        }

        if (leader2 == player4)
        {
            StartCoroutine(followLeader2Above(player5));
            StartCoroutine(followLeader2Below(player6));
            player4.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            player5.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            player6.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
        }
        else if (leader2 == player5)
        {
            StartCoroutine(followLeader2Above(player6));
            StartCoroutine(followLeader2Below(player4));
            player4.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            player5.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            player6.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
        }
        else if (leader2 == player6)
        {
            StartCoroutine(followLeader2Above(player4));
            StartCoroutine(followLeader2Below(player5));
            player4.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            player5.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            player6.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
        }
    }

    IEnumerator followLeader1Above(GameObject player)
    {

        Vector3 leader1Pos = leader1.transform.position;
        yield return new WaitForSeconds(0.2f);
        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(leader1Pos.x - 200, leader1Pos.y + 100, leader1Pos.z), specSpeed);
    }

    IEnumerator followLeader1Below(GameObject player)
    {
        Vector3 leader1Pos = leader1.transform.position;
        yield return new WaitForSeconds(0.2f);
        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(leader1Pos.x - 200, leader1Pos.y - 100, leader1Pos.z), specSpeed);
    }

    IEnumerator followLeader2Above(GameObject player)
    {

        Vector3 leader2Pos = leader2.transform.position;
        yield return new WaitForSeconds(0.2f);
        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(leader2Pos.x + 200, leader2Pos.y + 100, leader2Pos.z), specSpeed);
    }

    IEnumerator followLeader2Below(GameObject player)
    {
        Vector3 leader2Pos = leader2.transform.position;
        yield return new WaitForSeconds(0.2f);
        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(leader2Pos.x + 200, leader2Pos.y - 100, leader2Pos.z), specSpeed);
    }
}


