using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotGunTwo : MonoBehaviour //доп поведение пушек у вражеских короблей
{
    public AudioSource AS;
    public float HP;
    public GameObject ammo;
    public Transform shotDir;

    private float timeShot;
    public float startTime;

    void Start()
    {
        timeShot = startTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ammo" || other.tag == "Player")
            HP -= 1;
    }

    void Update()
    {
        if (HP >= 6)
        {
            if (timeShot <= 0)
            {
                AS.Play();
                Instantiate(ammo, shotDir.position, Quaternion.identity);
                timeShot = startTime;
            }
            else timeShot -= Time.deltaTime;
        }
        else
        {
            if (timeShot <= 0)
            {
                AS.Play();
                Instantiate(ammo, shotDir.position, Quaternion.identity);
                timeShot = 0.3f;
            }
            else timeShot -= Time.deltaTime;
        }
    }
}
