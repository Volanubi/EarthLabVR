using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HClDelay : MonoBehaviour
{
    public GameObject RootOut;
    public GameObject RootIn;
    public GameObject oldTrigger;
    public float Seconds;

    public GameObject TriggerActivateG;
    public string InteractorTag;
    public GameObject TriggerFirst;

    public ScoreManager scoreManager;

    public int pointValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == InteractorTag)
        {
            if (TriggerFirst.activeInHierarchy == true)
            {
                StartCoroutine(Timer());
            }
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(Seconds);
        Debug.Log("It Worked");
        TriggerActivateG.SetActive(true);
        RootIn.SetActive(true);
        RootOut.SetActive(false);
        oldTrigger.SetActive(false);
        yield return null;
    }
}
