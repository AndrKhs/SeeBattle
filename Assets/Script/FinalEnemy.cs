using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalEnemy : MonoBehaviour
{
    public float HP;
    public Slider slider;
    public GameObject teleport;
    public GameObject wall;
    public Transform tp;

    void Update()
    {
        slider.value = HP;
    }

    void OnTriggerEnter2D(Collider2D other) //триггер на создание перехода сцену титров
    {
        if (other.gameObject.tag == "Ammo" || other.gameObject.tag == "Player")
        {
            HP -= 1f;
            if (HP <= 0f) //создание после смерти босса телепорта
            {
                Destroy(wall);
                Instantiate(teleport, tp.position, tp.rotation); 
                Destroy(gameObject);

            }

            if (other.gameObject.tag == "Ammo")
                Destroy(other.gameObject);
        }
    }
}