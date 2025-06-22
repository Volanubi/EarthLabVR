using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WateringCanNS : MonoBehaviour
{
    public string NozzleTag;
    public float TimeDelay;
    public GameObject ChangeMatObj;
    public Material newMat;

    [SerializeField] UnityEvent Events;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == NozzleTag)
        {
            StartCoroutine(Timer());
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(TimeDelay);

        ChangeMatObj.GetComponent<Renderer>().material = newMat;
        Events.Invoke();

        yield return null;
    }
}