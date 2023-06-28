using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;

    public float minY = -2f;
    public float maxY = 2f;

    void FixedUpdate()
    {
        PlayerYMovement();
        MovementLimit();
    }

    void PlayerYMovement()
    {
        float movementY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            movementY = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movementY = -1f;
        }

        Vector3 movement = new Vector3(0f, movementY, 0f) * speed;
        rb.velocity = movement;
    }

    void MovementLimit()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);
        transform.position = currentPosition;
    }
}
