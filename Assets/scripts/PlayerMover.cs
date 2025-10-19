using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.InputSystem;

public class playerMover : MonoBehaviour
{
    public float fixedSpeed = 5f;
    public float speed = 5f;
    Rigidbody2D rb;
    Vector2 acceleration = new Vector2(0, 0);

    public bool canMove = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {


         if (!canMove)
    {
        rb.linearVelocity = Vector2.zero;
        return;
    }
        acceleration = Vector2.zero;

        if (Keyboard.current.wKey.isPressed) { acceleration += Vector2.up; }
        if (Keyboard.current.sKey.isPressed) { acceleration += Vector2.down; }
        if (Keyboard.current.aKey.isPressed) { acceleration += Vector2.left; }
        if (Keyboard.current.dKey.isPressed) { acceleration += Vector2.right; }

        if (acceleration == Vector2.zero)
        {
            rb.linearVelocity = Vector2.zero;
        } else
        {
            acceleration.Normalize();
            rb.linearVelocity = acceleration * speed;
        }

    }
}
