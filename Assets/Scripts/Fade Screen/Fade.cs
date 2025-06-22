using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fade : MonoBehaviour
{
    [Header("Fade Elements")]
    public Image fadeImage;
    public float fadeDuration = 1f;

    [Header("Time Skip Settings")]
    public float blackScreenDelay = 1f;      // Time after full black before showing text
    public float textDisplayDuration = 2f;   // How long the text is visible before fade-in
    public TextMeshProUGUI timeSkipTMP;      // Reference to the TMP text (e.g., "3 Hours Later...")

    void Start()
    {
        if (timeSkipTMP != null)
        {
            timeSkipTMP.alpha = 0f;
        }

        StartCoroutine(FadeIn()); // Optional fade in on start
    }

    public void StartTimeSkip(string message = "1 Month Later")
    {
        StartCoroutine(TimeSkipSequence(message));
    }

    private IEnumerator TimeSkipSequence(string message)
    {
        // Fade screen to black
        yield return FadeOut();

        // Wait before showing text
        yield return new WaitForSeconds(blackScreenDelay);

        // Show text with fade-in
        if (timeSkipTMP != null)
        {
            timeSkipTMP.text = message;
            yield return FadeTMPTextIn(timeSkipTMP);
            yield return new WaitForSeconds(textDisplayDuration);
            yield return FadeTMPTextOut(timeSkipTMP);
        }

        // Fade screen back in
        yield return FadeIn();
    }

    public IEnumerator FadeIn()
    {
        float t = 0f;
        Color c = fadeImage.color;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            c.a = Mathf.Lerp(1, 0, t / fadeDuration);
            fadeImage.color = c;
            yield return null;
        }

        c.a = 0f;
        fadeImage.color = c;
    }

    public IEnumerator FadeOut()
    {
        float t = 0f;
        Color c = fadeImage.color;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            c.a = Mathf.Lerp(0, 1, t / fadeDuration);
            fadeImage.color = c;
            yield return null;
        }

        c.a = 1f;
        fadeImage.color = c;
    }

    private IEnumerator FadeTMPTextIn(TextMeshProUGUI tmp)
    {
        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            tmp.alpha = Mathf.Lerp(0f, 1f, t / fadeDuration);
            yield return null;
        }

        tmp.alpha = 1f;
    }

    private IEnumerator FadeTMPTextOut(TextMeshProUGUI tmp)
    {
        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            tmp.alpha = Mathf.Lerp(1f, 0f, t / fadeDuration);
            yield return null;
        }

        tmp.alpha = 0f;
    }
}