using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource Audio;

    void Start()
    {
        if (!PlayerPrefs.HasKey("volume")) Audio.volume = 1; //стандартные настройки
    }

    void Update()
    {
        Audio.volume = PlayerPrefs.GetFloat("volume"); // настройка пользователя
    }
}
