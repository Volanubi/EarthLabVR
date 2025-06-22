using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Try : MonoBehaviour
{
    public GameObject Change1;
    public GameObject Change2;

    private float triggerValue;
    public InputActionReference RTriggerReference;
    public InputActionReference LTriggerReference;

    private void Awake()
    {
        RTriggerReference.action.started += ToggleR;
        LTriggerReference.action.started += ToggleL;
    }

    private void OnDestroy()
    {
        RTriggerReference.action.started -= ToggleR;
        LTriggerReference.action.started -= ToggleL;
    }

    private void ToggleR(InputAction.CallbackContext context)
    {
        if (triggerValue > .2)
        {
            Change1.SetActive(false);
            Change2.SetActive(true);
        }

        else
        {
            Change1.SetActive(true);
            Change2.SetActive(false);
        }
    }

    private void ToggleL(InputAction.CallbackContext context)
    {
        if (triggerValue > .2)
        {
            Change1.SetActive(false);
            Change2.SetActive(true);
        }

        else
        {
            Change1.SetActive(true);
            Change2.SetActive(false);
        }
    }
}
