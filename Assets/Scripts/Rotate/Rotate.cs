using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool rotateX = false;
    public bool rotateY = false;
    public bool rotateZ = true;

    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = Vector3.zero;
        if (rotateX)
        {
            rotation += Vector3.right;
        }

        if (rotateY)
        {
            rotation += Vector3.up;
        }

        if (rotateZ)
        {
            rotation -= Vector3.forward;
        }

        transform.Rotate(rotation * speed * Time.deltaTime);

    }
}
