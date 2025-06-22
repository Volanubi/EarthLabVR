using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onebyone : MonoBehaviour
{
    public string tag;
    public GameObject Object;
    public GameObject TriggerOff;
    public GameObject ObjectOn;
    public GameObject TriggerOn;

    Rigidbody rb;

    void Start()
    {
        rb = Object.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == tag)
        {
            TriggerOff.SetActive(false);
            ObjectOn.SetActive(true);
            TriggerOn.SetActive(true);
            rb.isKinematic = false;

        }
    }
}
