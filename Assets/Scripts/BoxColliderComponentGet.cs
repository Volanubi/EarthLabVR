using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderComponentGet : MonoBehaviour
{
    public GameObject SocketInteractor;
    BoxCollider _bcol;
    void Start()
    {
        _bcol = gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter()
    {
        SocketInteractor.SetActive(true);
    }

    private void OnTriggerExit()
    {
        SocketInteractor.SetActive(false);
    }
}
