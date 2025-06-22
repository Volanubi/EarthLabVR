using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeZ : MonoBehaviour
{
    [SerializeField] private Vector3 change;

    public GameObject TweezTop;
    public string colliderTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == colliderTag)
        {
            TweezTop.transform.Rotate(change);
        }
    }
}
