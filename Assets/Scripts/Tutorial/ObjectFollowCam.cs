using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollowCam : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float distance = 1.0f;

    private void Update()
    {
        if (cameraTransform == null)
        {
            Debug.LogWarning("Camera Transform is not assigned.");
            return;
        }


        Vector3 flatForward = cameraTransform.forward;
        flatForward.y = 0;
        flatForward.Normalize();


        Vector3 targetPosition = cameraTransform.position + flatForward * distance;


        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.015f);


        Vector3 lookDirection = cameraTransform.position - transform.position;
        lookDirection.y = 0;
        if (lookDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }
}