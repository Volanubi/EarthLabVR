using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerCongrats : MonoBehaviour
{
    public GameObject LastCheck;
    public GameObject Congrats;
    public GameObject Menu;
    public GameObject UIElem;
    public GameObject FinalScoreTxt;
    public GameObject ScoreText;

    [SerializeField] UnityEvent Events;

    void Start()
    {
        if (LastCheck.activeInHierarchy == true)
        {
            Congrats.SetActive(true);
            FinalScoreTxt.SetActive(true);
            ScoreText.SetActive(false);
            Menu.SetActive(false);
            UIElem.SetActive(false);
            Events.Invoke();
        }
    }
}
