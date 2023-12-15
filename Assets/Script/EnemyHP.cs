using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public float HP;
    public Slider slider;
    public GameObject next;
    public GameObject wall;
    public GameObject wall2;
    public Transform NextPos;
    public GameObject teleport;
    public Transform tp;

    void Update()
    {
        slider.value = HP;
    }

    void OnTriggerEnter2D(Collider2D other) //триггер на создание перехода сцену титров и триггер на попадания
    {
        if (other.gameObject.tag == "Ammo" || other.gameObject.tag == "Player")
        {
            HP -= 1f;
            if (HP <= 0f)
            {
                Destroy(gameObject);
                Instantiate(next, NextPos.position, NextPos.rotation);
                Instantiate(teleport, tp.position, tp.rotation);
                Destroy(wall);
                Destroy(wall2);
            }

            if (other.gameObject.tag == "Ammo")
                Destroy(other.gameObject);
        }
    }
}