using UnityEngine;

public class TeleportCave : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform targetPosition; // Assign the target position in the Inspector
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player) // Check if the colliding object is the Player
        {
            Debug.Log("Player collided with checkpoint!");
            player.transform.position = targetPosition.position; // Move the player to the checkpoint
        }
    }
}