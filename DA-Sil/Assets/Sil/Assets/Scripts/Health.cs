using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public float hp;
    public float maxHp;
    public Slider slider1;
    public Slider slider2;
    private GameObject movementController;

    void Start()
    {
        movementController = GameObject.Find("MovementController");
    }

    void Update()
    {
        if (gameObject == movementController.GetComponent<FollowTheLeader>().leader1)
        {
            slider1 = GameObject.Find("Slider1").GetComponent<Slider>();
            if (hp > 0) slider1.value = HPCalculator();            
        }
        if (gameObject == movementController.GetComponent<FollowTheLeader>().leader2)
        {
            slider2 = GameObject.Find("Slider2").GetComponent<Slider>();
            if (hp > 0) slider2.value = HPCalculator();
        }        
        else
        {
            slider1 = null;
        }
        if (hp > maxHp) hp = maxHp;
    }
    public void TakeDamage(float amountOfDamage)
    {
        hp -= amountOfDamage;
        if (hp <= 0)
        {
            if (gameObject == movementController.GetComponent<FollowTheLeader>().leader2)
            {
                FollowTheLeader followTheLeader = GameObject.Find("MovementController").GetComponent<FollowTheLeader>();
                if (followTheLeader.leader2.GetComponent<Throw>().PickedUp > 0)
                {
                    for (int i = 0; i < followTheLeader.leader2.GetComponent<Throw>().PickedUp; i++)
                    {
                        GameObject bal = Instantiate(followTheLeader.leader2.GetComponent<Throw>().ball, followTheLeader.leader2.transform);
                        bal.GetComponent<BallMove>().isInAir = false;
                        bal.transform.parent = GameObject.Find("Balls").transform;
                    }
                }
                followTheLeader.ts2[followTheLeader.leader2Index] = null;
                followTheLeader.ts2PlayersAlive -= 1;
                if (followTheLeader.ts2PlayersAlive <=0)
                {
                    SceneManager.LoadScene(0);
                }
                movementController.GetComponent<FollowTheLeader>().leader2Index += 1;
                if (movementController.GetComponent<FollowTheLeader>().leader2Index > 3)
                {
                    movementController.GetComponent<FollowTheLeader>().leader2Index = 1;
                }
                if (followTheLeader.leader2Index == 0)
                {
                    if (followTheLeader.player4 != null)
                        followTheLeader.leader2 = followTheLeader.player4;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader2Index == 1)
                {
                    if (followTheLeader.player5 != null)
                        followTheLeader.leader2 = followTheLeader.player5;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader2Index == 2)
                {
                    if (followTheLeader.player6 != null)
                        followTheLeader.leader2 = followTheLeader.player6;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader2Index == 3)
                {
                    followTheLeader.leader2Index = 0;
                }
                if (followTheLeader.leader2Index == 0)
                {
                    if (followTheLeader.player4 != null)
                        followTheLeader.leader2 = followTheLeader.player4;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader2Index == 1)
                {
                    if (followTheLeader.player5 != null)
                        followTheLeader.leader2 = followTheLeader.player5;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader2Index == 2)
                {
                    if (followTheLeader.player6 != null)
                        followTheLeader.leader2 = followTheLeader.player6;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                Destroy(gameObject, 1);

            }
            if (gameObject == movementController.GetComponent<FollowTheLeader>().leader1)
            {
                FollowTheLeader followTheLeader = GameObject.Find("MovementController").GetComponent<FollowTheLeader>();
                if (followTheLeader.leader1.GetComponent<Throw>().PickedUp > 0)
                {
                    for (int i = 0; i < followTheLeader.leader1.GetComponent<Throw>().PickedUp; i++)
                    {
                        GameObject bal = Instantiate(followTheLeader.leader1.GetComponent<Throw>().ball, followTheLeader.leader2.transform);
                        bal.GetComponent<BallMove>().isInAir = false;
                        bal.transform.parent = GameObject.Find("Balls").transform;
                    }
                }
                followTheLeader.ts1[followTheLeader.leader1Index] = null;
                followTheLeader.ts1PlayersAlive -= 1;
                if (followTheLeader.ts1PlayersAlive <= 0)
                {
                    SceneManager.LoadScene(0);
                }
                movementController.GetComponent<FollowTheLeader>().leader1Index += 1;
                if (movementController.GetComponent<FollowTheLeader>().leader1Index > 3)
                {
                    movementController.GetComponent<FollowTheLeader>().leader1Index = 1;
                }
                if (followTheLeader.leader1Index == 0)
                {
                    if (followTheLeader.player1 != null)
                        followTheLeader.leader1 = followTheLeader.player1;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader1Index == 1)
                {
                    if (followTheLeader.player2 != null)
                        followTheLeader.leader1 = followTheLeader.player2;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader1Index == 2)
                {
                    if (followTheLeader.player3 != null)
                    {
                        followTheLeader.leader1 = followTheLeader.player3;
                    }
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                              if (followTheLeader.leader1Index == 0)
                {
                    if (followTheLeader.player1 != null)
                        followTheLeader.leader1 = followTheLeader.player1;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader1Index == 1)
                {
                    if (followTheLeader.player2 != null)
                        followTheLeader.leader1 = followTheLeader.player2;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader1Index == 2)
                {
                    if (followTheLeader.player3 != null)
                    {
                        followTheLeader.leader1 = followTheLeader.player3;
                    }
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader1Index == 3)
                {
                    followTheLeader.leader1Index = 0;
                }
                if (followTheLeader.leader1Index == 0)
                {
                    if (followTheLeader.player1 != null)
                        followTheLeader.leader1 = followTheLeader.player1;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader1Index == 1)
                {
                    if (followTheLeader.player2 != null)
                        followTheLeader.leader1 = followTheLeader.player2;
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }
                else if (followTheLeader.leader1Index == 2)
                {
                    if (followTheLeader.player3 != null)
                    {
                        followTheLeader.leader1 = followTheLeader.player3;
                    }
                    else
                    {
                        followTheLeader.leader1Index += 1;
                    }
                }

                if (Input.GetKeyDown(KeyCode.V))
                {
                    followTheLeader.leader1Index++;
                }
                Destroy(gameObject);

            }

        }        
    }
    float HPCalculator()
    {
        return hp / maxHp;
    }
    
}