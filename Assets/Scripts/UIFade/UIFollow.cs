using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollow : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform UI;
    [SerializeField] private float distance = 1.0f;

    private bool isCentered = false;

    private void Update()
    {
        Vector3 flatForward = cameraTransform.forward;
        flatForward.y = 0;
        flatForward.Normalize();

        Vector3 targetPosition = cameraTransform.position + flatForward * distance;

        MoveTowards(targetPosition);

        Vector3 lookDirection = cameraTransform.position - UI.position;
        lookDirection.y = 0;
        UI.rotation = Quaternion.LookRotation(lookDirection);
    }

    private Vector3 FindTargetPosition()
    {
        return cameraTransform.position + (cameraTransform.forward * distance);
    }

    private void MoveTowards(Vector3 targetPosition)
    {
        transform.position += (targetPosition - transform.position) * 0.015f;
    }

    private bool ReachedPosition(Vector3 targetPosition)
    {
        return Vector3.Distance(targetPosition, transform.position) < 0.1f;
    }
}
