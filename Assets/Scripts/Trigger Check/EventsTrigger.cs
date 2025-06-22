using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnterEvent;
    [SerializeField] UnityEvent onTriggerExitEvent;

    bool isDone = false;

    void OnTriggerEnter(Collider other)
    {
        if (!isDone)
        {
            onTriggerEnterEvent.Invoke();
            isDone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!isDone)
        {
            onTriggerExitEvent.Invoke();
            isDone = true;
        }
    }
}
