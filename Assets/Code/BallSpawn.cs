using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public float speedY = 2;
    public float speedX = 5;
    public GameObject thisObject;

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

        else if (other.CompareTag("UpperPaddle"))
        {
            speedX *= -1;
            speedY = 1;
            Debug.Log("Tag: Upper Paddle");
        }

        else if (other.CompareTag("MiddlePaddle"))
        {
            speedX *= -1;
            speedY = 0;
            Debug.Log("Tag: Middle Paddle");
        }

        else if (other.CompareTag("LowerPaddle"))
        {
            speedX *= -1;
            speedY = -1;
            Debug.Log("Tag: Lower Paddle");
        }

    }

    [NaughtyAttributes.Bi]
    void ResetBall()
    {
        transform.position = Vector3.zero;
        speedY = 0;
    }
}   
