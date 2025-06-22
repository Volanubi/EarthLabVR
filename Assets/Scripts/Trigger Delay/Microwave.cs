using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Microwave : MonoBehaviour
{
    public GameObject ColliderX;
    public GameObject ActivateFood;
    public GameObject ActivateDoor1;
    public GameObject DeactivateDoor2;
    public GameObject TriggerActivateG;

    [Header("After 20 secs do-")]
    [SerializeField] UnityEvent Event;

    void Start()
    {

        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(20);
        Debug.Log("Micro Worked");
        TriggerActivateG.SetActive(true);
        ColliderX.SetActive(false);
        ActivateFood.SetActive(true);
        ActivateDoor1.SetActive(true);
        DeactivateDoor2.SetActive(false);
        Event.Invoke();
        yield return null;
    }
}
