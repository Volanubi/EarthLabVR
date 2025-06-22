using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColorPulse : MonoBehaviour
{
    public Material buttonMaterial;
    public Color highlightColor = Color.green;
    public float pulseSpeed = 1f;

    private Color originalColor;
    private bool isPulsing = false;

    private void Start()
    {
        if (buttonMaterial != null)
            originalColor = buttonMaterial.color;
    }

    private void Update()
    {
        if (isPulsing)
        {
            float t = Mathf.PingPong(Time.time * pulseSpeed, 1.0f);
            buttonMaterial.color = Color.Lerp(originalColor, highlightColor, t);
        }
    }

    public void StartPulse()
    {
        isPulsing = true;
    }

    public void StopPulse()
    {
        isPulsing = false;
        buttonMaterial.color = originalColor;
    }
}