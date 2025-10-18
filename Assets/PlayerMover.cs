using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.InputSystem;

public class playerMover : MonoBehaviour
{
    public float fixedSpeed = 5f;
    public float speed = 5f;
    Rigidbody2D rb;
    Vector2 acceleration = new Vector2(0, 0);


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {

        if (Keyboard.current.wKey.isPressed) { acceleration = new Vector2(0, 0);  acceleration += Vector2.up; speed = fixedSpeed; }
        if (Keyboard.current.sKey.isPressed) { acceleration = new Vector2(0, 0); acceleration += Vector2.down; speed = fixedSpeed; }
        if (Keyboard.current.aKey.isPressed) { acceleration = new Vector2(0, 0); acceleration += Vector2.left; speed = fixedSpeed; }
        if (Keyboard.current.dKey.isPressed) { acceleration = new Vector2(0, 0); acceleration += Vector2.right; speed = fixedSpeed; }

        if (rb.linearVelocity == Vector2.zero)
        {
            acceleration.Normalize();
            rb.linearVelocity = acceleration * speed;

        } else
        {
            speed = Mathf.MoveTowards(speed, 0f, 5f * Time.fixedDeltaTime);
            rb.linearVelocity = acceleration * speed;
        }

    }
}
