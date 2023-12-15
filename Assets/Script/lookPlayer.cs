using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookPlayer : MonoBehaviour // поведение башни противника
{
    public float offset;
    private Transform Player;

    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 defference = transform.position - Player.position;
        float rotateZ = Mathf.Atan2(defference.y, defference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

    }
}
