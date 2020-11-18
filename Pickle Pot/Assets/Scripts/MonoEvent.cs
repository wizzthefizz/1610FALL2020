using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvent : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent, onEnableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    void Start()
    {
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }
}
