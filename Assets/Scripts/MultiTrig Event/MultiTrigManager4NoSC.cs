using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MultiTrigManager4NoSC : MonoBehaviour
{
    [Header("Empties")]
    public GameObject Obj1;
    public GameObject Obj2;
    public GameObject Obj3;
    public GameObject Obj4;

    [SerializeField] UnityEvent Events;

    void Update()
    {
        Active();
    }
    private void Active()
    {
        if (Obj1.activeInHierarchy == true && Obj2.activeInHierarchy == true && Obj3.activeInHierarchy == true && Obj4.activeInHierarchy == true)
        {
            Events.Invoke();
        }
    }
}
