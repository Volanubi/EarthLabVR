using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MultiTrigManager3 : MonoBehaviour
{
    [Header("Score Manager")]
    public GameObject TriggerActivateG;
    public GameObject TriggerFirst;
    public GameObject TriggerActivateR;
    public GameObject TriggerActivateY;
    public ScoreManager scoreManager;
    public int pointValue;
    public SkipDrop skipDrop;

    [Header("Empties")]
    public GameObject Obj1;
    public GameObject Obj2;
    public GameObject Obj3;

    bool isDone = false;

    [SerializeField] UnityEvent Events;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        skipDrop = GameObject.Find("Summary Eval").GetComponent<SkipDrop>();
    }
    void Update()
    {
        if (Obj1.activeInHierarchy == true && Obj2.activeInHierarchy == true && Obj3.activeInHierarchy == true)
        {
            if (TriggerFirst.activeInHierarchy == true)
            {
                TriggerActivateG.SetActive(true);
                TriggerActivateR.SetActive(false);
                TriggerActivateY.SetActive(false);
                Events.Invoke();
            }

            else
            {
                if (!isDone)
                {
                    TriggerActivateG.SetActive(false);
                    TriggerActivateR.SetActive(true);
                    TriggerActivateY.SetActive(true);
                    scoreManager.ChangeScore(pointValue);
                    skipDrop.Skip();
                    isDone = true;
                }
            }
        }
    }
}

