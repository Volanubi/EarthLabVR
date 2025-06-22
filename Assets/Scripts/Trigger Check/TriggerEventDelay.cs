using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventDelay : MonoBehaviour
{
    public float TimeAmount;
    [SerializeField] UnityEvent onTriggerEnter;
    public string Tag;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == Tag)
        {
            StartCoroutine(Timer());
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(TimeAmount);
        onTriggerEnter.Invoke();
        yield return null;
    }
}
