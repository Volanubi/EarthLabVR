using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class Brightness : MonoBehaviour
{
    [SerializeField] private Slider weightSlider;
    [SerializeField] private Volume volume;

    void Start()
    {
        if (PlayerPrefs.HasKey("volumeWeight"))
        {
            LoadVolume();
        }

        else
        {
            SetVolumeWeight();
        }
    }

    public void SetVolumeWeight()
    {
        float weight = weightSlider.value;
        volume.weight = weight;
        PlayerPrefs.SetFloat("volumeWeight", volume.weight);
    }

    private void LoadVolume()
    {
        weightSlider.value = PlayerPrefs.GetFloat("volumeWeight");
        SetVolumeWeight();
    }
}