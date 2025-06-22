using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScreen : MonoBehaviour
{
    public bool fadeOnStart = true;
    public float fadeDuration = 2f;
    public Color fadeColor = Color.black;
    public AnimationCurve fadeCurve = AnimationCurve.Linear(0, 0, 1, 1);
    public string colorPropertyName = "_Color";

    private Renderer rend;
    private Coroutine currentFadeCoroutine;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;

        if (fadeOnStart)
            StartCoroutine(FadeIn());
    }

    public IEnumerator FadeIn()
    {
        yield return Fade(1f, 0f);
    }

    public IEnumerator FadeOut()
    {
        yield return Fade(0f, 1f);
    }

    private IEnumerator Fade(float startAlpha, float endAlpha)
    {
        if (currentFadeCoroutine != null)
            StopCoroutine(currentFadeCoroutine);

        currentFadeCoroutine = StartCoroutine(FadeRoutine(startAlpha, endAlpha));
        yield return currentFadeCoroutine;
    }

    private IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        rend.enabled = true;

        float timer = 0f;
        while (timer <= fadeDuration)
        {
            float t = timer / fadeDuration;
            float alpha = Mathf.Lerp(alphaIn, alphaOut, fadeCurve.Evaluate(t));

            Color newColor = fadeColor;
            newColor.a = alpha;
            rend.material.SetColor(colorPropertyName, newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color finalColor = fadeColor;
        finalColor.a = alphaOut;
        rend.material.SetColor(colorPropertyName, finalColor);

        if (alphaOut == 0f)
            rend.enabled = false;

        currentFadeCoroutine = null;
    }
}