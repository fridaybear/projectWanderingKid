using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int HP = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("weapon"))
        {
            HP -= 1;

            if (HP <= 0)
            {
                HP = 3;
                transform.position = Vector2.zero; // Reset position
            }

        }
    }
}
