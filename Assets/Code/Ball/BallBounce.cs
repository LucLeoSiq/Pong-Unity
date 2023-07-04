using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float speedY = 2;
    public float speedX = 10;
    public GameObject thisObject;
    public bool isMoving = false;
    
    private bool bounceCooldown = false;

    void Start()
    {
        transform.position = Vector3.zero;
        isMoving = true;
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.right * speedX * Time.deltaTime);
            transform.Translate(Vector3.down * speedY * Time.deltaTime);
        }
    }   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            speedY *= -1;
        }

        else if (other.CompareTag("UpperPaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            speedY = -1;
            StartCoroutine(ActivateBounceCooldown());
        }

        else if (other.CompareTag("MiddlePaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            speedY = 0;
            StartCoroutine(ActivateBounceCooldown());
        }

        else if (other.CompareTag("LowerPaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            speedY = 1;
            StartCoroutine(ActivateBounceCooldown());
        }
    }

    private IEnumerator ActivateBounceCooldown()
    {
        bounceCooldown = true;

        yield return new WaitForSeconds(0.01f);

        bounceCooldown = false;
    }
}   
