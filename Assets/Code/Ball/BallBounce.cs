using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallBounce : MonoBehaviour
{
    public GameObject thisObject;
    public SoundManager soundManager;

    public float waitBeforeStart = 3f;

    [Header("Ball Movement")]
    public float angleY = 1f;
    public float minAngleY = 0.5f;
    public float maxAngleY = 5f;
    public float speedX = 10;

    public bool isMoving = false;
    
    private bool bounceCooldown = false;

    void Awake()
    {
        transform.position = Vector3.zero;
        isMoving = false;
        StartCoroutine(WaitBeforeMoving(waitBeforeStart));
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.right * speedX * Time.deltaTime);
            transform.Translate(Vector3.down * angleY * Time.deltaTime);
        }
    }   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            angleY *= -1;
            soundManager.playBoundaryBounceSFX(); 
        }

        else if (other.CompareTag("UpperPaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            angleY = Random.Range(-minAngleY, -maxAngleY);
            StartCoroutine(ActivateBounceCooldown());
            soundManager.playPaddleBounceSFX();
        }

        else if (other.CompareTag("MiddlePaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            angleY = 0;
            StartCoroutine(ActivateBounceCooldown());
            soundManager.playPaddleBounceSFX();
        }

        else if (other.CompareTag("LowerPaddle") && (bounceCooldown == false))
        {
            speedX *= -1;
            angleY = Random.Range(minAngleY, maxAngleY);
            StartCoroutine(ActivateBounceCooldown());
            soundManager.playPaddleBounceSFX();
        }
    }

    private IEnumerator ActivateBounceCooldown()
    {
        bounceCooldown = true;

        yield return new WaitForSeconds(0.01f);

        bounceCooldown = false;
    }
    private IEnumerator WaitBeforeMoving(float i)
    {
        yield return new WaitForSeconds(i);
        
        isMoving = true;
    }
}   
