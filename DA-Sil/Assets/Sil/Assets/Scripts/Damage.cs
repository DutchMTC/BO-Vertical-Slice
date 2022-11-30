using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagee : MonoBehaviour
{
    [SerializeField] int damage;

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Team1")
        {
            if (collision.GetComponent<FollowTheLeader>().Leader1) collision.GetComponent<Health>().TakeDamage(damage);
        }
        if (collision.tag == "Team2")
        {
            if (collision.GetComponent<FollowTheLeader>().Leader2) collision.GetComponent<Health>().TakeDamage(damage);
        }
        
    }
}
