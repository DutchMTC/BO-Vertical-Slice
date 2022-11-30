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
        if (hp <= 0) { Destroy(gameObject, 1); }
        if (hp >= maxHp) { hp = maxHp; }
    }
}
