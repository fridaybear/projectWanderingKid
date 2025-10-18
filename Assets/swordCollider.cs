using UnityEngine;
using System.Collections;

public class SwordCollisions : MonoBehaviour
{
    public float knockbackForce = 10f;       // How strong the push is
    public float knockbackDuration = 0.2f;   // How long the push lasts

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if we hit an enemy
        if (collision.gameObject.CompareTag("enemy"))
        {
            Rigidbody2D enemyRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (enemyRb != null)
            {
                // Direction from sword to enemy
                Vector2 direction = (collision.transform.position - transform.position).normalized;

                // Apply knockback
                StartCoroutine(DoKnockback(enemyRb, direction));
            }
        }
    }

    private IEnumerator DoKnockback(Rigidbody2D enemyRb, Vector2 direction)
    {
        // Stop any current enemy movement
        enemyRb.linearVelocity = Vector2.zero;

        // Apply instant knockback
        enemyRb.linearVelocity = direction * knockbackForce;

        // Wait for knockback duration
        yield return new WaitForSeconds(knockbackDuration);

        // Stop movement after knockback
        enemyRb.linearVelocity = Vector2.zero;
    }
}
