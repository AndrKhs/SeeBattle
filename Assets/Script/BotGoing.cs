using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotGoing : MonoBehaviour //случайное передвижение бота по заданным точкам
{
    public int HP;
    public int number;
    public float speed1;
    public float speed2;
    private float waitTime;
    public float startWaitTime;
    public Transform[] moveSpots;
    private int randomSpots;

    void Start()
    {
        randomSpots = Random.Range(0, number);
        waitTime = startWaitTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ammo" || other.tag == "Player")
            HP -= 1;
    }

    void FixedUpdate()
    {
        if (HP >= 5)
            Move(moveSpots, speed1);
        else
            Move(moveSpots, speed2);
    }

    void Move(Transform[] move, float speed)
    {
        transform.position = Vector2.MoveTowards(transform.position, move[randomSpots].position, speed * Time.fixedDeltaTime);
        if (Vector2.Distance(transform.position, move[randomSpots].position) < 0.2f)
            randomSpots = Random.Range(0, number);
    }
}