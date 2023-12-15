using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public float Time;

    void Start()
    {
        Invoke("LoadMenu", Time); //проигрывание сцены титров
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("SampleScene"); //возврат в главное меню
    }
}
