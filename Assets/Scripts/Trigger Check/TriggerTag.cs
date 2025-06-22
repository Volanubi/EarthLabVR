using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTag : MonoBehaviour
{
    public GameObject TriggerActivateG;
    public string InteractorTag;

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
            TriggerActivateG.SetActive(true);

        }

        else
        {
            scoreManager.ChangeScore(pointValue);
            skipDrop.Skip();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == InteractorTag)
        {
            TriggerActivateG.SetActive(false);
        }
    }
}


