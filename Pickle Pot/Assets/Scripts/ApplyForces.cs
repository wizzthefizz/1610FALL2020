using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    public Rigidbody rBody;
    public float force = 30;

    private void OnMouseDown()
    {
        rBody.AddForce(0,force,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
