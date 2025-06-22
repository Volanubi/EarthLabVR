using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRules : MonoBehaviour
{
    public GameObject TriggerActivateG;
    public GameObject TriggerInteractor;
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
        if (other.gameObject == TriggerInteractor)
        {
            if (TriggerFirst.activeInHierarchy == true)
            {
                TriggerActivateG.SetActive(true);
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
        if (other.gameObject == TriggerInteractor)
        {
            TriggerActivateG.SetActive(false);
            TriggerActivateR.SetActive(false);
            TriggerActivateY.SetActive(false);
        }
    }
}
