using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class TurnAdvanceTrigger : MonoBehaviour
{
    [Tooltip("Input Action for right-hand joystick turn (Vector2).")]
    public InputActionReference turnAction;

    [Tooltip("Minimum joystick X input (left/right) to trigger turn.")]
    public float turnThreshold = 0.2f;

    private bool hasTurned = false;

    public delegate void OnTurnDetected();
    public event OnTurnDetected TurnComplete;
    [SerializeField] UnityEvent Events;

    void OnEnable()
    {
        if (turnAction != null)
        {
            turnAction.action.Enable();
        }
    }

    void OnDisable()
    {
        if (turnAction != null)
        {
            turnAction.action.Disable();
        }
    }

    void Update()
    {
        if (hasTurned || turnAction == null) return;

        Vector2 turnValue = turnAction.action.ReadValue<Vector2>();

        if (Mathf.Abs(turnValue.x) >= turnThreshold)
        {
            Debug.Log("Player turned using right joystick — advancing tutorial.");
            hasTurned = true;
            TurnComplete?.Invoke();
            Events.Invoke();
        }
    }
}
