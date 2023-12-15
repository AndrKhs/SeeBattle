using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAmmo : MonoBehaviour //обработчик патронов противника
{
    public GameObject explosion2;
    public GameObject explosion;
    public float offset;
    public float speed;
    public float destroyTime;
    private Transform player;
    private Vector2 target;
    public Animator animator;

    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

        Vector3 defference = player.position - transform.position;
        float rotateZ = Mathf.Atan2(defference.y, defference.x) * Mathf.Rad2Deg; //вычесление итого вектора выстрела
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

    }

    void FixedUpdate() //попадание по цели
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyAmmo();
        }
    }

    void DestroyAmmo() //унечтожение патрона
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other) //фиксация попадания
    {
        if (other.tag == "Wall")
        {
            Instantiate(explosion2, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            Instantiate(explosion2, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
