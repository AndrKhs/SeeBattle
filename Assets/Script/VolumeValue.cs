using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour //настройка громкости
{
    public Slider slider;
    public float MusicVolume;

    void Start()
    {
        MusicVolume = slider.value;
        if (!PlayerPrefs.HasKey("volume")) slider.value = 1;
        else slider.value = PlayerPrefs.GetFloat("volume");
    }

    void Update()
    {
        if (MusicVolume != slider.value)
        {
            PlayerPrefs.SetFloat("volume", slider.value);
            PlayerPrefs.Save();
            MusicVolume = slider.value;
        }
    }
}
