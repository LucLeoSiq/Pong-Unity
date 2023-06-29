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
        if (other.CompareTag("Bounce"))
        {
            speedY = speedY * -1;
            speedX = speedX * -1;
        }

        if (other.CompareTag("Boundary"))
        {
            speedY = speedY * -1;
        }

        else if (other.CompareTag("UpperPaddle"))
        {

        }

        else if (other.CompareTag("MiddlePaddle"))
        {

        }

        else if (other.CompareTag("LowerPaddle"))
        {

        }

    }
}   
