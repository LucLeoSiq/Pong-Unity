using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public int speed = 5;
    public GameObject thisObject;

    void Start()
    {
        thisObject.SetActive(true);
        transform.position = Vector3.zero;
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bounce"))
        {
            Debug.Log("Bounce Trigger Set"); 
        }
    }
}
