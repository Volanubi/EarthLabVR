using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject TriggerActivate;
    public GameObject TriggerInteractor;
    public GameObject TriggerFirst;
    public GameObject TriggerActivateY;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == TriggerInteractor)
        {
            TriggerActivate.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == TriggerInteractor)
        {
            TriggerActivate.SetActive(false);
        }
    }
}
