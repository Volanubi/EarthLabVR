using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollide : MonoBehaviour
{
    public int pointValue;
    public ScoreManager scoreManager;


    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        scoreManager.ChangeScore(pointValue);
    }
}
