using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YouHP : MonoBehaviour //обработка HP у игрока
{
    public int HP;
    public Slider slider;

    void Update()
    {
        slider.value = HP;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "AmmoEnemy")
        {
            HP -= 1;
            if (HP <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("YouLose");
            }
        }

        if (other.gameObject.tag == "Wall")
        {
            HP -= 1;
            if (HP <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("YouLose");
            }
        }

        if (other.gameObject.tag == "Enemy") 
        {
            Destroy(gameObject);
            SceneManager.LoadScene("YouLose");
        }
    }
}