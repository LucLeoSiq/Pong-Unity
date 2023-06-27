using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0f, verticalInput, 0f);
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void MovementLimit()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);
        transform.position = currentPosition;
    }
}
