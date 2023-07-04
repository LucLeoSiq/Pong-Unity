using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float speedY = 2;
    public float startSpeed = 4;
    public float speedX;
    public GameObject thisObject;
    public bool isMoving = false;
    
    private bool bounceCooldown = false;

    void Start()
    {
        thisObject.SetActive(true);
        transform.position = Vector3.zero;
        speedX = startSpeed;
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
            Debug.Log("Tag: Boundary");
        }

        else if (other.CompareTag("UpperPaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            speedY = -1;
            StartCoroutine(ActivateBounceCooldown());
            //Debug.Log("Tag: Upper Paddle");
            //IncreaseBallSpeed(1);
        }

        else if (other.CompareTag("MiddlePaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            speedY = 0;
            StartCoroutine(ActivateBounceCooldown());
            //Debug.Log("Tag: Middle Paddle");
            //IncreaseBallSpeed(1);
        }

        else if (other.CompareTag("LowerPaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            speedY = 1;
            StartCoroutine(ActivateBounceCooldown());
            //Debug.Log("Tag: Lower Paddle");
            //IncreaseBallSpeed(1);
        }
    }

    private IEnumerator ActivateBounceCooldown()
    {
        bounceCooldown = true;
        Debug.Log("BounceCooldown activated!");

        yield return new WaitForSeconds(0.01f);

        bounceCooldown = false;
        Debug.Log("BounceCooldown over!");
    }

    [NaughtyAttributes.Button]
    void ResetBall()
    {
        transform.position = Vector3.zero;
        speedY = 0;
    }

    void IncreaseBallSpeed(float increaseSpeedBy)
    {
        if ((speedX > 0) && (speedX < 10))
        {
            speedX += increaseSpeedBy;
        }

        if ((speedX < 0) && (speedX < -10))
        {
            speedX -= increaseSpeedBy;
        }
    }
}   
