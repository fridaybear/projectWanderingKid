using UnityEngine;

public class cutsceneTrigger : MonoBehaviour
{
    public GameObject playerItem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerItem.SetActive(true);
        }
    }
}
