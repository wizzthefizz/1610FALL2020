using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvents : MonoBehaviour
{
    public UnityEvent myUnityEvent;

    private void OnTriggerEnter(Collider other)
    {
        myUnityEvent.Invoke();
    }
}

