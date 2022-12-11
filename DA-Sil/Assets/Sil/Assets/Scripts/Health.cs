using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
            Destroy(gameObject, 1);
        }        
    }
    float HPCalculator()
    {
        return hp / maxHp;
    }
    
}