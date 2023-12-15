using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //управление игрока
{
    public float moveSpeed;
    public Rigidbody2D Rigidbody;
    Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (movement.x == 1 && movement.y == 1)
            Move(movement, 1.5f, 45f);
        if (movement.x == -1 && movement.y == 1)
            Move(movement, 1.5f, 135f);
        if (movement.x == 1 && movement.y == -1)
            Move(movement, 1.5f, -45f);
        if (movement.x == -1 && movement.y == -1)
            Move(movement, 1.5f, -135f);
        if (movement.x == 1 && movement.y == 0)
            Move(movement, 1f, 0f);
        if (movement.x == -1 && movement.y == 0)
            Move(movement, 1f, 180f);
        if (movement.x == 0 && movement.y == 1)
            Move(movement, 1f, 90f);
        if (movement.x == 0 && movement.y == -1)
            Move(movement, 1f, -90f);
    }

    void Move(Vector2 movement, float delSpeed, float angle)
    {
        Rigidbody.MovePosition(Rigidbody.position + movement / delSpeed * moveSpeed * Time.fixedDeltaTime);
        Rigidbody.MoveRotation(angle);
    }
}
