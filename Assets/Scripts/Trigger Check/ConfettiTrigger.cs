using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConfettiTrigger : MonoBehaviour
{
    [Header("If last check triggered, Confetti boom")]
    public GameObject ifCheck;
    bool isDone = false;
    [SerializeField] UnityEvent Events;

    void Update()
    {
        if (ifCheck.activeInHierarchy == true)
        {
            if (!isDone)
            {
                Events.Invoke();
                isDone = true;
            }

        }
    }
}
