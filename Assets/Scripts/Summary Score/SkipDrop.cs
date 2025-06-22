using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkipDrop : MonoBehaviour
{
    public TMP_Text SkipAmount;
    public TMP_Text DropAmount;
    public int currentSkip = 0;
    public int currentDrop = 0;
    bool isDone = false;

    public void Skip()
    {
        currentSkip += 1;
        isDone = true;
    }

    public void finalSkipAmount()
    {
        SkipAmount.text = currentSkip.ToString();
    }

    public void Drop()
    {
        if (!isDone)
        {
            currentDrop += 1;
            isDone = true;
        }
        StartCoroutine(Delay());

    }

    public void finalDropAmount()
    {
        DropAmount.text = currentDrop.ToString();
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        if (isDone)
        {
            isDone = false;
        }
    }

}
