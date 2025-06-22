using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMinus : MonoBehaviour
{
    public string InteractorTag;
    public string ToothpickTag;
    public ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag != InteractorTag && other.gameObject.transform.tag != ToothpickTag)
        {
            scoreManager.ChangeScore(10);
        }
    }

}
