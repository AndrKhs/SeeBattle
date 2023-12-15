using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Leveling");
    }

    public void Level1()
    {
        SceneManager.LoadScene("BeginningOfHistory");
    }

    public void Level2()
    {
        SceneManager.LoadScene("SceneAfterLevel1");
    }

    public void Level3()
    {
        SceneManager.LoadScene("SceneAfterLevel2");
    }

    public void Level4()
    {
        SceneManager.LoadScene("SceneAfterLevel3");
    }

    public void Level5()
    {
        SceneManager.LoadScene("SceneAfterLevel4");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
