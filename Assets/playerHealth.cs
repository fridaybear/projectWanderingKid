using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int baseHealth = 3;

    public bool collisionEnabled = true;
    public int currentHealth;
    public float knockbackForce = 10f;
    public float knockbackDuration = 0.1f; // how long the push lasts

    void Start()
    {
        currentHealth = baseHealth;   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy") && collisionEnabled == true)
        {
            Rigidbody2D enemyRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (enemyRb != null)
            {
                Vector2 direction = (collision.transform.position - transform.position).normalized;
                StartCoroutine(DoKnockback(enemyRb, direction));
            }

            if (currentHealth > 0)
            {
                currentHealth -= 1; 
            }
            else
            {
                transform.position = new Vector2(0, 0);
                currentHealth = baseHealth;
            }
        }
    }

    private System.Collections.IEnumerator DoKnockback(Rigidbody2D enemyRb, Vector2 direction)
    {
        collisionEnabled = false;
        Vector2 originalVelocity = enemyRb.linearVelocity;
        enemyRb.linearVelocity = direction * knockbackForce;
        yield return new WaitForSeconds(knockbackDuration);

        collisionEnabled = true;
        enemyRb.linearVelocity = originalVelocity; 
    }
}
