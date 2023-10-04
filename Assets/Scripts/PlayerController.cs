using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; // Field
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);

        bool isKeyWasJustPressed = Input.GetKeyDown(KeyCode.Space); //Checks if Space is pressed
        if (isKeyWasJustPressed == true)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 500, 0);
        }
                
        

    }

    private void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Physics.gravity * GetComponent<Rigidbody>().mass);
    }
}
