using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charge : MonoBehaviour
{
    [SerializeField] float charge1 = 0f;
    [SerializeField] float charge2 = 0f;
    [SerializeField] float maxCharge = 10f;
    private GameObject movementController;
    Slider Slider1;
    Slider Slider2;
    void Start()
    {
        movementController = GameObject.Find("MovementController");
        Slider1 = GameObject.Find("Canvas1").GetComponent<Slider>();
        Slider2 = GameObject.Find("Canvas2").GetComponent<Slider>();
    }


    void Update()
    {
        if (gameObject == movementController.GetComponent<FollowTheLeader>().leader1)
        {
            charge1 += 0.1f * Time.deltaTime;
            if (charge1 < maxCharge) Slider1.value = charge1;
            if (Input.GetKey(KeyCode.K)) charge1 += 1 * Time.deltaTime;
        }
        if (gameObject == movementController.GetComponent<FollowTheLeader>().leader2)
        {
            charge2 += 0.1f * Time.deltaTime;
            if (charge2 < maxCharge) Slider2.value = charge2;
            if (Input.GetKey(KeyCode.L)) charge2 += 1 * Time.deltaTime;
        }
        if (charge1 > maxCharge) charge1 = maxCharge;
        if (charge2 > maxCharge) charge2 = maxCharge;
    }
}