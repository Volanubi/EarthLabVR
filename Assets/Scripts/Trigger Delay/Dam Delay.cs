using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamDelay : MonoBehaviour
{
    public float Seconds;

    [SerializeField] UnityEvent Events;

    void Update()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(Seconds);
        Events.Invoke();
    }
}
