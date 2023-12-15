using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour //триггер взрыва
{
    public float destroyTime; 

    void Start()
    {
        Invoke("Destroy", destroyTime);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
