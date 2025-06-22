using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;
    public int currentScore;

    [Header("If Score is Zero (0)")]
    [SerializeField] UnityEvent Events;

    public void ChangeScore(int points)
    {
        currentScore -= points;
        scoreText.text = currentScore.ToString() + "/100";
        if (currentScore <= 0)
        {
            Events.Invoke();
        }
        AudioManager.instance.Play("ScoreDrop");
    }

    public void finalScoreUpdate()
    {
        finalScoreText.text = currentScore.ToString();
    }
}
