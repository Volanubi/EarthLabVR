using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTagRules : MonoBehaviour
{
    public GameObject TriggerActivateG;
    public string InteractorTag;
    public GameObject TriggerFirst;
    public GameObject TriggerActivateR;
    public GameObject TriggerActivateY;

    public ScoreManager scoreManager;
    public int pointValue;

    public SkipDrop skipDrop;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        skipDrop = GameObject.Find("Summary Eval").GetComponent<SkipDrop>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == InteractorTag)
        {
            if (TriggerFirst.activeInHierarchy == true)
            {
                TriggerActivateG.SetActive(true);
                TriggerActivateR.SetActive(false);
                TriggerActivateY.SetActive(false);
            }


            else
            {
                TriggerActivateR.SetActive(true);
                TriggerActivateY.SetActive(true);
                scoreManager.ChangeScore(pointValue);
                skipDrop.Skip();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == InteractorTag)
        {
            TriggerActivateG.SetActive(false);
            TriggerActivateR.SetActive(false);
            TriggerActivateY.SetActive(false);
        }
    }
}
