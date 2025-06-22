using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColliderComponentsGet : MonoBehaviour
{
    public GameObject SocketInteractor;
    SphereCollider _scol;
    void Start()
    {
        _scol = gameObject.GetComponent<SphereCollider>();
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
