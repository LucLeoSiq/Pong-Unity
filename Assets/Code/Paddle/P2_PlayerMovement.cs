using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb2d;

    public float minY = -5f;
    public float maxY = 5f;

    void FixedUpdate()
    {
        PlayerYMovement();
        MovementLimit();
    }

    private void PlayerYMovement()
    {
        float movementY = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementY = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movementY = -1f;
        }

        Vector3 movement = new Vector3(0f, movementY, 0f) * speed;
        rb2d.velocity = movement;
    }

    private void MovementLimit()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);
        transform.position = currentPosition;
    }

}
