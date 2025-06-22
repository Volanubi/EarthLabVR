using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MultiTrigManager11 : MonoBehaviour
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
    public GameObject Obj4;
    public GameObject Obj5;
    public GameObject Obj6;
    public GameObject Obj7;
    public GameObject Obj8;
    public GameObject Obj9;
    public GameObject Obj10;
    public GameObject Obj11;

    bool isDone = false;

    [SerializeField] UnityEvent Events;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        skipDrop = GameObject.Find("Summary Eval").GetComponent<SkipDrop>();
    }

    void Update()
    {
        if (Obj1.activeInHierarchy == true && Obj2.activeInHierarchy == true && Obj3.activeInHierarchy == true && Obj4.activeInHierarchy == true && Obj5.activeInHierarchy == true
        && Obj6.activeInHierarchy == true && Obj7.activeInHierarchy == true && Obj8.activeInHierarchy == true && Obj9.activeInHierarchy == true && Obj10.activeInHierarchy == true
        && Obj11.activeInHierarchy == true)
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
