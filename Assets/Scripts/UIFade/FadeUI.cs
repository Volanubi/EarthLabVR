using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup UIGroup;
    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;
    public GameObject CanvasUI;

    public void showUI()
    {
        fadeIn = true;
        CanvasUI.SetActive(true);
    }

    public void hideUI()
    {
        fadeOut = true;
    }

    private void Update()
    {
        if (fadeIn)
        {
            if (UIGroup.alpha < 1)
            {
                UIGroup.alpha += Time.deltaTime;
                if (UIGroup.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }

        if (fadeOut)
        {
            if (UIGroup.alpha >= 0)
            {
                UIGroup.alpha -= Time.deltaTime;
                if (UIGroup.alpha == 0)
                {
                    fadeOut = false;
                    CanvasUI.SetActive(false);
                }
            }
        }
    }
}
