using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Transform YouSpawn;
    public Transform EnemySpawn;

    void OnTriggerEnter2D (Collider2D other) //обработка соприкосновения игрока со стеной
    {
        if (other.tag == "Player")
        {
            other.transform.position = YouSpawn.position;
        }
    }
}
