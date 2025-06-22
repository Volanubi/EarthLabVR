using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

[RequireComponent(typeof(Renderer))]
public class FadeOutAfterDelay : MonoBehaviour
{
    public float delay = 5f;
    public float fadeDuration = 2f;

    private TextMeshPro tmp;
    private Color originalColor;

    [SerializeField] UnityEvent Events;
    [SerializeField] UnityEvent EventStart;

    private void Start()
    {
        tmp = GetComponent<TextMeshPro>();
        originalColor = tmp.color;

        StartCoroutine(FadeOutText());
        EventStart.Invoke();

    }

    private IEnumerator FadeOutText()
    {
        yield return new WaitForSeconds(delay);

        float elapsed = 0f;

        while (elapsed < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsed / fadeDuration);
            tmp.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Ensure it ends fully transparent
        tmp.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
        Events.Invoke();

        Destroy(gameObject);
    }
}