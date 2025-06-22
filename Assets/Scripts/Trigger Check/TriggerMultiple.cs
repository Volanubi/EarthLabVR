using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMultiple : MonoBehaviour
{
    public GameObject TriggerThisOne;
    public GameObject TriggerThisSecond;
    public GameObject TriggerThisThird;

    public string ColliderTagOne;
    public string ColliderTagTwo;
    public string ColliderTagThree;

    public GameObject ActivateThisOne;
    public GameObject ActivateThisTwo;
    public GameObject ActivateThisThree;

    public GameObject TriggerFirst;
    public GameObject TriggerActivateG;
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
        if (other.gameObject.transform.tag == ColliderTagOne && TriggerThisSecond.gameObject.transform.tag == ColliderTagTwo && TriggerThisThird.gameObject.transform.tag == ColliderTagThree)
        {

            TriggerActivateG.SetActive(true);
            ActivateThisOne.SetActive(true);
            ActivateThisTwo.SetActive(true);
            ActivateThisThree.SetActive(true);
        }


        else
        {
            TriggerActivateR.SetActive(true);
            TriggerActivateY.SetActive(true);
            scoreManager.ChangeScore(pointValue);
            skipDrop.Skip();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == ColliderTagOne && TriggerThisSecond.gameObject.transform.tag == ColliderTagTwo && TriggerThisThird.gameObject.transform.tag == ColliderTagThree)
        {
            TriggerActivateG.SetActive(false);
            TriggerActivateR.SetActive(false);
            TriggerActivateY.SetActive(false);
            ActivateThisOne.SetActive(false);
            ActivateThisTwo.SetActive(false);
            ActivateThisThree.SetActive(false);
        }
    }
}
