using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class setting : MonoBehaviour //настройка для FullScreen
{
    Resolution[] rsl;
    List<string> resolutions;
    public Dropdown dropdown;
    public Dropdown DropDown;
    private bool isFullScreen;

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }

    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }

    public void Awake()
    {
        resolutions = new List<string>();
        rsl = Screen.resolutions;
        foreach (var i in rsl)
            resolutions.Add(i.width + "x" + i.height);
        dropdown.ClearOptions();
        dropdown.AddOptions(resolutions);
    }
}
