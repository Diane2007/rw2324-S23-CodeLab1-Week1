using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public float forceAmount = 0;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("W pressed");
            rb.AddForce(0, 0, forceAmount);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A pressed");
            rb.AddForce(-forceAmount, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D pressed");
            rb.AddForce(forceAmount, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S pressed");
            rb.AddForce(0,0, -forceAmount);
        }
    }
}
