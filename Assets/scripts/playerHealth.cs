using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int baseHealth = 3;
    public int currentHealth;

    void Start()
    {
        currentHealth = baseHealth;   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy") )
        {
            if (currentHealth > 0) { currentHealth -= 1; }
            else
            {
                transform.position = new Vector2(0, 0);
                currentHealth = baseHealth;
            }
        }
    }
}
