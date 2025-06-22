using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPointsMultiple : MonoBehaviour
{
    public GameObject ObjectOne;
    public GameObject ObjectTwo;

    public ScoreManager scoreManager;
    public int pointValue;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject != ObjectOne || other.gameObject != ObjectTwo)
        {
            scoreManager.ChangeScore(pointValue);
        }
    }
}
