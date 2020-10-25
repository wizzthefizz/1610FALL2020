using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float horsePower = 0;
    [SerializeField] public float rpm;
    [SerializeField] public float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] private GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] private List<WheelCollider> allWheels;
    [SerializeField] private int wheelsOnGround;


    void start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }
    

    // Fixed Update is called once per physics frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");


        verticalInput = Input.GetAxis("Vertical");

        if (IsOnGround())
        {
            transform.Rotate(Vector3.up, (turnSpeed * horizontalInput * Time.deltaTime));
            transform.Translate(Vector3.forward * (Time.deltaTime * horsePower * verticalInput));
            playerRb.AddRelativeForce(Vector3.forward * (verticalInput * horsePower));

            speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: " + speed + "mph");

            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);

        }
    }

    bool IsOnGround()
        {
            wheelsOnGround = 0;
            foreach (WheelCollider wheel in allWheels)
            {
                if (wheel.isGrounded)
                {
                    wheelsOnGround++;
                }
            }

            if (wheelsOnGround == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

