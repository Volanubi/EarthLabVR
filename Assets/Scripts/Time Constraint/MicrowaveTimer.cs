using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MicrowaveTimer : MonoBehaviour
{
    [SerializeField] TMP_Text TimerText;
    public float remainingTime;
    public bool TimerOn = false;

    void Start()
    {

        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (remainingTime > 0.1)
            {
                remainingTime -= Time.deltaTime;
                updateTimer(remainingTime);
            }

            else
            {
                remainingTime = 0;
                TimerOn = false;
            }
        }

        void updateTimer(float currentTime)
        {
            currentTime += 1;

            float minutes = Mathf.FloorToInt(remainingTime / 60);
            float seconds = Mathf.FloorToInt(remainingTime % 60);
            TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
