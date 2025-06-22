using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LookAroundTrigger : MonoBehaviour
{
    public Transform xrCamera;
    public float yawThreshold = 30f;
    public float pitchThreshold = 20f;

    private Quaternion startingRotation;
    private bool initialized = false;
    private bool triggered = false;

    public delegate void OnLookAroundComplete();
    public event OnLookAroundComplete LookComplete;

    [SerializeField] UnityEvent Events;

    void Start()
    {
        if (xrCamera == null)
        {
            Debug.LogError("XR Camera not assigned.");
            return;
        }


        startingRotation = xrCamera.rotation;
        initialized = true;
    }

    void Update()
    {
        if (!initialized || triggered) return;


        Quaternion currentRotation = xrCamera.rotation;


        Vector3 startingEuler = startingRotation.eulerAngles;
        Vector3 currentEuler = currentRotation.eulerAngles;

        float yawDiff = Mathf.DeltaAngle(startingEuler.y, currentEuler.y);
        float pitchDiff = Mathf.DeltaAngle(startingEuler.x, currentEuler.x);


        if (Mathf.Abs(yawDiff) >= yawThreshold || Mathf.Abs(pitchDiff) >= pitchThreshold)
        {
            Debug.Log("Look Around step completed.");
            triggered = true;
            Events.Invoke();


            LookComplete?.Invoke();
        }
    }
}
