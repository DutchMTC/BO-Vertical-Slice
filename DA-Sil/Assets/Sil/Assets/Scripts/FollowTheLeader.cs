using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheLeader : MonoBehaviour
{
    [SerializeField] private float specSpeed;

    public Vector3 Distance = new Vector3();

    public int team1Alive = 3;
    public int team2Alive = 3;
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

        if (leader1 == player1)
        {
            if (player2)
                nextLeader1 = player2;
        }
        else if (leader1 == player2)
        {
            if (player3)
                nextLeader1 = player3;
        }
        else if (leader1 == player3)
        {
            if (player1)
                nextLeader1 = player1;
        }

        if (leader2 == player4)
        {
            if (player5)
                nextLeader2 = player5;
            else if (player6)
                nextLeader2 = player6;
            else if (player4)
                nextLeader2 = player4;
        }
        else if (leader2 == player5)
        {
            if (player6)
                nextLeader2 = player6;
            else if (player4)
                nextLeader2 = player4;
            else if (player5)
                nextLeader2 = player5;
        }
        else if (leader2 == player6)
        {
            if (player4)
                nextLeader2 = player4;
            else if (player5)
                nextLeader2 = player5;
            else if (player6)
                nextLeader2 = player6;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            leader1 = nextLeader1;
        }

        if (leader1 == player1)
        {
            if (player2)
                StartCoroutine(followLeader1Above(player2));
            if (player3)
                StartCoroutine(followLeader1Below(player3));
            if (player1)
                player1.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            else
                player1.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player2)
                player2.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            else
                player2.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player3)
                player3.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            else
                player3.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
        }
        else if (leader1 == player2)
        {
            if (player3)
                StartCoroutine(followLeader1Above(player3));
            if (player1)
                StartCoroutine(followLeader1Below(player1));
            if (player1)
                player1.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            else
                player1.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player2)
                player2.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            else
                player2.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player3)
                player3.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            else
                player3.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
        }
        else if (leader1 == player3)
        {
            if (player1)
                StartCoroutine(followLeader1Above(player1));
            if (player2)
                StartCoroutine(followLeader1Below(player2));
            if (player1)
                player1.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            else
                player1.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player2)
                player2.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            else
                player2.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player3)
                player3.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            else
                player3.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            leader2 = nextLeader2;
        }

        if (leader2 == player4)
        {
            if (player5)
                StartCoroutine(followLeader2Above(player5));
            if (player6)
                StartCoroutine(followLeader2Below(player6));
            if (player4)
                player4.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            else
                player4.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player5)
                player5.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            else
                player5.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player6)
                player6.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            else
                player6.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
        }
        else if (leader2 == player5)
        {
            if (player6)
                StartCoroutine(followLeader2Above(player6));
            if (player4)
                StartCoroutine(followLeader2Below(player4));
            if (player4)
                player4.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            else
                player4.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player5)
                player5.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            else
                player5.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player6)
                player6.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            else
                player6.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
        }
        else if (leader2 == player6)
        {
            if (player4)
                StartCoroutine(followLeader2Above(player4));
            if (player5)
                StartCoroutine(followLeader2Below(player5));
            if (player4)
                player4.transform.parent.GetComponent<Canvas>().sortingOrder = 3;
            else
                player4.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player5)
                player5.transform.parent.GetComponent<Canvas>().sortingOrder = 5;
            else
                player5.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
            if (player6)
                player6.transform.parent.GetComponent<Canvas>().sortingOrder = 4;
            else
                player6.transform.parent.GetComponent<Canvas>().sortingOrder = 0;
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

