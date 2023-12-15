using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour //меню паузы
{
    public static bool GamePause = false;
    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause) Resume();
            else PauseGame();
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }

    void PauseGame()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f; 
        GamePause = true;
    }

    public void levelMenu()
    {
        Resume();
        SceneManager.LoadScene("Leveling");
    }

    public void LoadMenu()
    {
        Resume();
        SceneManager.LoadScene("SampleScene");
    }

    public void GameOut()
    {
        Application.Quit();
    }
}
