using UnityEngine;
public class AI_Paddle : MonoBehaviour
{
    public Transform ballTransform;
    public float paddleSpeed;

    public Rigidbody2D paddleRb;

    [Header("Paddle Movement Boundary")]
    public float minY = -5f;
    public float maxY = 5f;

    private void Start()
    {
        paddleRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Calculate the target position based on the ball's y-position
        Vector2 targetPosition = new Vector2(transform.position.x, ballTransform.position.y);

        paddleRb.MovePosition(Vector2.Lerp(transform.position, targetPosition, Time.fixedDeltaTime * paddleSpeed));

        MovementLimit();
    }

    void MovementLimit()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);
        transform.position = currentPosition;
    }
}
