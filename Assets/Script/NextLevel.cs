﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) //скрипт на переход игровой сцены
    {
        if (other.tag == "Player")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
