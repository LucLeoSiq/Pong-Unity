using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    public BallBounce ballBounce;
    public SoundManager soundManager;

    public float delayTime = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BackZone"))
        {
            ResetBall();
            StartCoroutine(MoveAfterDelay());
            soundManager.playScoreSFX();
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
        ballBounce.angleY = Random.Range(-2f, 2f);
        ballBounce.isMoving = true;
    }
}
