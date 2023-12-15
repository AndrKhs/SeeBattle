using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour //поведение башни игрока
{
    public AudioSource AS;
    public float offset;
    public GameObject ammo;
    public Transform shotDir;

    private float timeShot;
    public float startTime;

    void FixedUpdate()
    {
        Vector3 defference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(defference.y, defference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        if (timeShot <= 0)
        {
            if (Input.GetMouseButtonDown(0)) //запуск выстрела
            {
                AS.Play();
                Instantiate(ammo, shotDir.position, transform.rotation);
                timeShot = startTime;
            }
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }
}
