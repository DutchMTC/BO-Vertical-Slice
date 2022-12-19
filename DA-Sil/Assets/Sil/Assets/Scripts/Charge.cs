using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charge : MonoBehaviour
{
    [SerializeField] float charge1 = 0f;
    [SerializeField] float charge2 = 0f;
    [SerializeField] float maxCharge = 10f;
    Slider Slider1;
    Slider Slider2;
    void Start()
    {
        Slider1 = GameObject.Find("Charge1").GetComponent<Slider>();
        Slider2 = GameObject.Find("Charge2").GetComponent<Slider>();
    }

    
    void Update()
    {
        if (charge1 > maxCharge) charge1 = maxCharge;
        if (charge2 > maxCharge) charge2 = maxCharge;
        if (charge1 < maxCharge) Slider1.value = charge1;
        if (charge2 < maxCharge) Slider2.value = charge2;
        if (Input.GetKey(KeyCode.K)) charge1 += 1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.L)) charge2 += 1 * Time.deltaTime;
    }
}
