using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int baseHealth = 3;

    public bool collisionEnabled = true;
    public int currentHealth;
    public float knockbackForce = 10f;
    public float knockbackDuration = 0.2f; // how long the push lasts

    public Health heartsUI;
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

            if (currentHealth > 1)
            {
                currentHealth -= 1;
                heartsUI.UpdateHearts(currentHealth);
            }
            else
            {
                transform.position = new Vector2(0, 0);
                currentHealth = baseHealth;
                heartsUI.UpdateHearts(currentHealth);
            }
        }
    }

    private System.Collections.IEnumerator DoKnockback(Rigidbody2D enemyRb, Vector2 direction)
    {
    collisionEnabled = false;

    enemyRb.linearVelocity = Vector2.zero;

    enemyRb.linearVelocity = direction * knockbackForce;

    yield return new WaitForSeconds(knockbackDuration);

    enemyRb.linearVelocity = Vector2.zero;

    collisionEnabled = true;
    }
}
