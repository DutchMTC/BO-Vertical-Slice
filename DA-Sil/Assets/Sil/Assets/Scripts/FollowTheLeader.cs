using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheLeader : MonoBehaviour
{
    [SerializeField] private float specSpeed;

    public Vector3 Distance = new Vector3();

    public GameObject leader1;
    public int leader1Index;

    public GameObject leader2;
    public int leader2Index;


    public List<GameObject> ts1 = new List<GameObject>();
    public List<GameObject> ts2 = new List<GameObject>();
    GameObject player1;
    GameObject player2;
    GameObject player3;
    GameObject player4;
    GameObject player5;
    GameObject player6;

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
        ts1.Add(player1);
        ts1.Add(player2);
        ts1.Add(player3);
        ts2.Add(player4);
        ts2.Add(player5);
        ts2.Add(player6);

        specSpeed = 1f;

        leader1 = player1;
        leader2 = player2;
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

        if (Input.GetKeyDown(KeyCode.V))
        {
            leader1Index++;
        }

        if(leader1 == player1)
        {
            StartCoroutine(followLeader1Above(player2));
            StartCoroutine(followLeader1Below(player3));
        }
        else if(leader1 == player2)
        {
            player1.transform.position = Vector3.MoveTowards(player1.transform.position, new Vector3(leader1Pos.position.x - 250, leader1Pos.position.y + 150, leader1Pos.position.z), specSpeed);
            player3.transform.position = Vector3.MoveTowards(player3.transform.position, new Vector3(leader1Pos.position.x - 250, leader1Pos.position.y - 150, leader1Pos.position.z), specSpeed);
        }
        else if (leader1 == player3)
        {
            player1.transform.position = Vector3.MoveTowards(player1.transform.position, new Vector3(leader1Pos.position.x - 250, leader1Pos.position.y + 150, leader1Pos.position.z), specSpeed);
            player2.transform.position = Vector3.MoveTowards(player2.transform.position, new Vector3(leader1Pos.position.x - 250, leader1Pos.position.y - 150, leader1Pos.position.z), specSpeed);
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
            player5.transform.position = Vector3.MoveTowards(player5.transform.position, new Vector3(leader2Pos.position.x, leader2Pos.position.y, leader2Pos.position.z + 2), specSpeed);
            player6.transform.position = Vector3.MoveTowards(player6.transform.position, new Vector3(leader2Pos.position.x - 2, leader2Pos.position.y, leader2Pos.position.z), specSpeed);
        }
        else if (leader2 == player5)
        {
            player4.transform.position = Vector3.MoveTowards(player4.transform.position, new Vector3(leader2Pos.position.x, leader2Pos.position.y, leader2Pos.position.z + 2), specSpeed);
            player6.transform.position = Vector3.MoveTowards(player6.transform.position, new Vector3(leader2Pos.position.x - 2, leader2Pos.position.y, leader2Pos.position.z), specSpeed);
        }
        else if (leader2 == player6)
        {
            player4.transform.position = Vector3.MoveTowards(player4.transform.position, new Vector3(leader2Pos.position.x, leader2Pos.position.y, leader2Pos.position.z + 2), specSpeed);
            player5.transform.position = Vector3.MoveTowards(player5.transform.position, new Vector3(leader2Pos.position.x - 2, leader2Pos.position.y, leader2Pos.position.z), specSpeed);
        }
    }

    IEnumerator followLeader1Above(GameObject player)
    {

        Vector3 leader1Pos = leader1.transform.position;
        yield return new WaitForSeconds(0.2f);
        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(leader1Pos.x - 250, leader1Pos.y + 150, leader1Pos.z), specSpeed);
    }

    IEnumerator followLeader1Below(GameObject player)
    {
        Vector3 leader1Pos = leader1.transform.position;
        yield return new WaitForSeconds(0.2f);
        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(leader1Pos.x - 250, leader1Pos.y - 150, leader1Pos.z), specSpeed);
    }
}


