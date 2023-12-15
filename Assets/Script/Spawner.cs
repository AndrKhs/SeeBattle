using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public int HP;
    public Slider slider;
    public GameObject Enemy;
    public Transform Spawn;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ammo" || other.tag == "Player")
            HP -= 1; //уменьшение хп от столкновения с объектами и патронами
        if (other.gameObject.tag == "Ammo")
            Destroy(other.gameObject); //уничтожение патронов
    }

    void Update()
    {
        slider.value = HP;
        if (HP == 0)
        {                                                               //уничтожение коробля
            Destroy(gameObject);
            Instantiate(Enemy, Spawn.position, Spawn.rotation);
        }
    }
}
