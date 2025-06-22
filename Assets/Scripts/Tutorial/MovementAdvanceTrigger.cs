using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class MovementAdvanceTrigger : MonoBehaviour
{
    [Tooltip("Input Action for left-hand joystick movement (Vector2).")]
    public InputActionReference moveAction;

    [Tooltip("Minimum joystick magnitude to trigger movement (e.g., 0.1).")]
    public float movementThreshold = 0.1f;

    private bool hasMoved = false;

    public delegate void OnMoveDetected();
    public event OnMoveDetected MoveComplete;

    [SerializeField] UnityEvent Events;

    void OnEnable()
    {
        if (moveAction != null)
        {
            moveAction.action.Enable();
        }
    }

    void OnDisable()
    {
        if (moveAction != null)
        {
            moveAction.action.Disable();
        }
    }

    void Update()
    {
        if (hasMoved || moveAction == null) return;

        Vector2 moveValue = moveAction.action.ReadValue<Vector2>();

        if (moveValue.magnitude >= movementThreshold)
        {
            Debug.Log("Player moved — advancing tutorial.");
            hasMoved = true;
            MoveComplete?.Invoke();
            Events.Invoke();
        }
    }
}
