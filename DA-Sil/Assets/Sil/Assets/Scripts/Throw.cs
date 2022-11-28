using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    internal int thrower;

    void Start()
    {

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(ball);
            thrower = 1;
        }

        if (Input.GetKeyDown(KeyCode.Backslash))
        {
            Instantiate(ball);
            thrower = 2;
        }
    }
}
