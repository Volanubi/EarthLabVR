using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToRigidbody : MonoBehaviour
{
    public string tagToAdd;

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag(tagToAdd))
        {
            other.transform.SetParent(transform);
        }
    }
}
