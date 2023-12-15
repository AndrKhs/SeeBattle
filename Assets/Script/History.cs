using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class History : MonoBehaviour //скрипт на переход сцены из истории в игру
{
    public float Time;

    void Start()
    {
        Invoke("LoadLevel", Time);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
