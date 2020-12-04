using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class JumpingInputanimation : MonoBehaviour
{
    private Animator anims;

    private void Start()
    {
        anims = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anims.SetTrigger("Jump");
        }
    }
}
