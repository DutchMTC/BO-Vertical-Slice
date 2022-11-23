using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheLeader : MonoBehaviour
{
    public Vector3 Distance = new Vector3();
    public int Leader1 = 0;
    public int Leader2 = 0;
    public List<GameObject> ts1 = new List<GameObject>();
    public List<GameObject> ts2 = new List<GameObject>();
    GameObject Player1;
    GameObject Player2;
    GameObject Player3;
    GameObject Player4;
    GameObject Player5;
    GameObject Player6;
    void Start()
    {
        Player1 = GameObject.Find("Player1");
        Player2 = GameObject.Find("Player2");
        Player3 = GameObject.Find("Player3");
        Player4 = GameObject.Find("Player4");
        Player5 = GameObject.Find("Player5");
        Player6 = GameObject.Find("Player6");
        ts1.Add(Player1);
        ts1.Add(Player2);
        ts1.Add(Player3);
        ts2.Add(Player4);
        ts2.Add(Player5);
        ts2.Add(Player6);
    }

    void Update()
    {
        
    }
}
