using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 forwardForce = new Vector2(0, 1);
    public Vector2 rightForce = new Vector2(1, 0);
    public Vector2 backForce = new Vector2(0, -1);
    public Vector2 leftForce = new Vector2(-1, 0);
    public KeyCode forwardKey;
    public KeyCode backKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    private Rigidbody2D playerRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 playerVelocity = playerRb.linearVelocity;
        Vector2 velocityChange = Vector2.zero;

        if (Input.GetKey(forwardKey))
        {
            velocityChange += forwardForce;
        }
        if (Input.GetKey(backKey))
        {
            velocityChange += backForce;
        }
        if (Input.GetKey(rightKey))
        {
            velocityChange += rightForce;
        }
        if (Input.GetKey(leftKey))
        {
            velocityChange += leftForce;
        }
        velocityChange = velocityChange.normalized;
        playerVelocity += velocityChange;
    }


}
