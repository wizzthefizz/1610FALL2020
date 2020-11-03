using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 3f, gravity = -9.81f, jumpForce = 30f;

    private Vector3 moveDirection;
    private float yDirection;
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

        controller.Move(moveDirection * Time.deltaTime);
    }
}
