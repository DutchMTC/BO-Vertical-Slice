using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;
    public int maxHp;
    void Start()
    {

    }

    void Update()
    {
        if (hp >= maxHp)
        {
            hp = maxHp;
        }
    }
    public void TakeDamage(int amountOfDamage)
    {
        hp -= amountOfDamage;
        if (hp <= 0)
        {
            Destroy(gameObject, 1);
        }
        
    }
    
}