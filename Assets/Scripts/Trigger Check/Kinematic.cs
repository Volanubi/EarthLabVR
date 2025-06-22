using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinematic : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Object;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Object)
        {
            StartCoroutine(Timer());
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        rb.isKinematic = false;
        yield return null;
    }
}
