using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHP = 3;
    public int HP;

    void Start()
    {
        HP = maxHP;   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("weapon"))
        {
            HP -= 1;

            // Check if enemy is dead
            if (HP <= 0)
            {
                HP = maxHP;                    // Reset HP
                transform.position = Vector2.zero; // Reset position

                // Optional: reset speed or other stats here
                EnemyTracking et = GetComponent<EnemyTracking>();
                if (et != null)
                    et.speed = 2;  // default speed
            }
        }
    }
}
