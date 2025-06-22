using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AutoGlowAfterIdle : MonoBehaviour
{
    public float idleTimeBeforeGlow = 10f;
    public float pulseSpeed = 4f;
    public float minWidth = 1f;
    public float maxWidth = 6f;

    private Outline outline;
    private XRBaseInteractable interactable;
    private float lastInteractionTime;
    private bool isPulsing = true;

    void Awake()
    {
        outline = GetComponent<Outline>();
        interactable = GetComponent<XRBaseInteractable>();

        outline.enabled = true;

        interactable.hoverEntered.AddListener(OnInteraction);
        interactable.hoverExited.AddListener(OnInteraction);
        interactable.selectEntered.AddListener(OnInteraction);
        interactable.selectExited.AddListener(OnInteraction);
    }

    void Update()
    {
        if (!isPulsing && Time.time - lastInteractionTime >= idleTimeBeforeGlow)
        {
            outline.enabled = true;
            isPulsing = true;
        }

        if (isPulsing)
        {
            float pulse = (Mathf.Sin(Time.time * pulseSpeed) + 1f) / 2f;
            float width = Mathf.Lerp(minWidth, maxWidth, pulse);
            outline.OutlineWidth = width;
        }
    }

    void OnInteraction(BaseInteractionEventArgs args)
    {
        lastInteractionTime = Time.time;

        if (isPulsing)
        {
            isPulsing = false;
            outline.enabled = false;
        }
    }

    void OnDestroy()
    {
        if (interactable != null)
        {
            interactable.hoverEntered.RemoveListener(OnInteraction);
            interactable.hoverExited.RemoveListener(OnInteraction);
            interactable.selectEntered.RemoveListener(OnInteraction);
            interactable.selectExited.RemoveListener(OnInteraction);
        }
    }
}