using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float speedY = 2;
    public float speedX = 5;
    public GameObject thisObject;
    
    private bool bounceCooldown = false;

    void Start()
    {
        thisObject.SetActive(true);
        transform.position = Vector3.zero;
    }

    void Update()
    {
        transform.Translate(Vector3.right * speedX * Time.deltaTime);
        transform.Translate(Vector3.down * speedY * Time.deltaTime);
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
            Debug.Log("Tag: Upper Paddle");
        }

        else if (other.CompareTag("MiddlePaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            speedY = 0;
            StartCoroutine(ActivateBounceCooldown());
            Debug.Log("Tag: Middle Paddle");
        }

        else if (other.CompareTag("LowerPaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            speedY = 1;
            StartCoroutine(ActivateBounceCooldown());
            Debug.Log("Tag: Lower Paddle");
        }
    }

    private IEnumerator ActivateBounceCooldown()
    {
        bounceCooldown = true;
        Debug.Log("BounceCooldown activated!");

        yield return new WaitForSeconds(1f);

        bounceCooldown = false;
        Debug.Log("BounceCooldown over!");
    }

    [NaughtyAttributes.Button]
    void ResetBall()
    {
        transform.position = Vector3.zero;
        speedY = 0;
    }
}   
