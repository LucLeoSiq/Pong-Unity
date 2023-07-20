using System.Collections;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    public BallBounce ballBounce;
    public SoundManager soundManager;

    public float delayTime = 1f;

    private void Update()
    {
        ResetIfOutOfBounds();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("P1_Backzone") || other.CompareTag("P2_Backzone"))
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

    private void ResetIfOutOfBounds()
    {
        if (transform.position.x < -12f || transform.position.x > 12f)
        {
            ResetBall();
            StartCoroutine(MoveAfterDelay());
            Debug.Log("Ball out of X bounds");
        }

        if (transform.position.y < -6f || transform.position.y > 6f)
        {
            ResetBall();
            StartCoroutine(MoveAfterDelay());
            Debug.Log("Ball out of Y bounds");
        }
    }
}
