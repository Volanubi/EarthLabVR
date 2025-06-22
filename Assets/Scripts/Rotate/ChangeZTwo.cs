using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeZTwo : MonoBehaviour
{
    [SerializeField] private Vector3 change;

    public GameObject TweezBot;
    public string colliderTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == colliderTag)
        {
            TweezBot.transform.Rotate(change);
        }
    }
}
