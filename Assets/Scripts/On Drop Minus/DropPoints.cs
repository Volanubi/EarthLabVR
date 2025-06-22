using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPoints : MonoBehaviour
{
    public GameObject floor;
    public ScoreManager scoreManager;
    public SkipDrop skipDrop;

    public int pointValue;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        skipDrop = GameObject.Find("Summary Eval").GetComponent<SkipDrop>();

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == floor)
        {
            scoreManager.ChangeScore(pointValue);
            skipDrop.Drop();
        }
    }
}
