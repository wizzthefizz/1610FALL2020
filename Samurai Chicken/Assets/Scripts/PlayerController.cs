using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public CharacterController controller;
    public float moveSpeed = 3f, gravity = -9.81f, jumpForce = 30f;

    private Vector3 moveDirection;
    private float yDirection;

    public Animator playerAnim;


    private void Start()
    {
       playerRb = GetComponent<Rigidbody>();
       playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput, yDirection,0);

        yDirection += gravity * Time.deltaTime;
        
        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Animation>().Play("Chicken2");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Animation>().Play("Chicken2");
        }
        
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);

    }
}
