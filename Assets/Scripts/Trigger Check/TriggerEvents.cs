using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    [SerializeField] UnityEvent onSelect;
    [SerializeField] UnityEvent onDeselect;
    public string Tag;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == Tag)
        {
            onTriggerEnter.Invoke();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == Tag)
        {
            onTriggerExit.Invoke();
        }
    }

    void OnSelect(Collider other)
    {
        if (other.gameObject.transform.tag == Tag)
        {
            onSelect.Invoke();
        }
    }

    void OnDeselect(Collider other)
    {
        if (other.gameObject.transform.tag == Tag)
        {
            onDeselect.Invoke();
        }
    }
}
