using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ButtonHighlight : MonoBehaviour
{
    public Color highlightColor = Color.green;
    public float pulseSpeed = 1f;

    private Material buttonMaterial;

    private void Start()
    {
        // Get and clone the material so this object has its own instance
        Renderer renderer = GetComponent<Renderer>();
        buttonMaterial = renderer.material;

        // Enable emission keyword to make sure Unity renders it
        buttonMaterial.EnableKeyword("_EMISSION");
    }

    private void Update()
    {
        float emission = Mathf.PingPong(Time.time * pulseSpeed, 1.0f);
        Color finalColor = highlightColor * emission;
        buttonMaterial.SetColor("_EmissionColor", finalColor);
    }
}
