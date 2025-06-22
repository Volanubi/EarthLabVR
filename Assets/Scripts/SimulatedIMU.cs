using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimulatedIMU : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 lastVelocity;
    public Vector3 linearAcceleration;

    public TMP_Text imuText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastVelocity = rb.velocity;
    }

    void FixedUpdate()
    {
        Vector3 currentVelocity = rb.velocity;
        Vector3 acceleration = (currentVelocity - lastVelocity) / Time.fixedDeltaTime;
        linearAcceleration = transform.InverseTransformDirection(acceleration);
        lastVelocity = currentVelocity;

        if (imuText != null)
        {
            imuText.text = $"IMU Acceleration:\nX={linearAcceleration.x:F2} m/s²\n" +
                           $"Y={linearAcceleration.y:F2} m/s²\n" +
                           $"Z={linearAcceleration.z:F2} m/s²";
        }
    }
}
