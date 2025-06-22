using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMinus : MonoBehaviour
{
    public GameObject TriggerInteractor;

    public ScoreManager scoreManager;
    public int pointValue;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != TriggerInteractor)
        {
            scoreManager.ChangeScore(pointValue);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == TriggerInteractor)
        {
            scoreManager.ChangeScore(pointValue);
        }
    }

}
