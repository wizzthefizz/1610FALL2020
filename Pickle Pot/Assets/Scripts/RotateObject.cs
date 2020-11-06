using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 15f;
    public bool canRotate;

    public void ChangeCanRotate(bool can)
    {
        canRotate = can;
    }
    void Update()
    {
        if (canRotate)
        {
            var finalSpeed = rotateSpeed * Time.deltaTime;
            transform.Rotate(0,0,finalSpeed);
        }
      
    }
    
}
