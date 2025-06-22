using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OverFire : MonoBehaviour
{
    public GameObject TriggerOn;
    public float Seconds;

    public GameObject TriggerActivateG;
    public string InteractorTag;

    [SerializeField] UnityEvent Events;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == InteractorTag)
        {
            StartCoroutine(Timer());
        }

    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(Seconds);
        TriggerActivateG.SetActive(true);
        TriggerOn.SetActive(true);
        Events.Invoke();
        yield return null;
    }
}
