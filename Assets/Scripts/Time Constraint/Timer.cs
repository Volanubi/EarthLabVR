using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Timer Settings")]
    [SerializeField] TMP_Text TimerText;
    public Image timeBarFill;
    public float remainingTime;
    public float totalTime;
    public bool TimerOn = false;

    [Header("If time is up Event")]
    [SerializeField] UnityEvent Event;

    void Start()
    {
        remainingTime = totalTime;
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (remainingTime > .1)
            {
                remainingTime -= Time.deltaTime;
                updateTimer(remainingTime);
                float fill = remainingTime / totalTime;
                timeBarFill.fillAmount = fill;
                if (fill < 0.2f)
                {
                    timeBarFill.color = Color.red;
                }
            }

            else
            {
                remainingTime = 0;
                TimerOn = false;
                Event.Invoke();

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
