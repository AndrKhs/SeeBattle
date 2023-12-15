using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotGun : MonoBehaviour //поведение пушек у вражеских короблей
{
    public AudioSource AS;
    public GameObject ammo;
    public Transform shotDir;

    private float timeShot;
    public float startTime;

    void Start()
    {
        timeShot = startTime;
    }

    void Update()
    {
        if (timeShot <= 0)
        {
            AS.Play();
            Instantiate(ammo, shotDir.position, Quaternion.identity);
            timeShot = startTime;
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }
}
