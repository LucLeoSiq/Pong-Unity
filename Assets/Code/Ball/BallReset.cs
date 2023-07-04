using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    public BallBounce ballBounce;
    private float delayTime = 0.1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BackZone"))
        {
            ResetBall();
            StartCoroutine(MoveAfterDelay());
        }
    }

    [NaughtyAttributes.Button]
    void ResetBall()
    {
        ballBounce.isMoving = false;
        transform.position = Vector3.zero;
    }

    private IEnumerator MoveAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);
            
        MoveInRandomDirection();

        yield return null;        
    }

    [NaughtyAttributes.Button]
    public void MoveInRandomDirection()
    {
        ballBounce.speedY = Random.Range(-0.5f, 0.5f);
        ballBounce.speedX = ballBounce.startSpeed;
        ballBounce.isMoving = true;
    }
}