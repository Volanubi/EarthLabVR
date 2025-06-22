using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    public GameObject Nozzle;
    public GameObject TriggerActivateG;
    public GameObject TriggerFirst;
    public GameObject TriggerActivateR;
    public GameObject TriggerActivateY;

    public ScoreManager scoreManager;
    public int pointValue;

    public GameObject ChangeMatObj;
    public Material newMat;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Nozzle)
        {
            StartCoroutine(Timer());
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Worked");


        if (TriggerFirst.activeInHierarchy == true)
        {
            TriggerActivateG.SetActive(true);
            ChangeMatObj.GetComponent<Renderer>().material = newMat;
        }

        else
        {
            TriggerActivateR.SetActive(true);
            TriggerActivateY.SetActive(true);
            scoreManager.ChangeScore(pointValue);
        }
        yield return null;
    }
}
