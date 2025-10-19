using UnityEngine;

public class TeleportFight1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform targetPositionFight; // Assign the target position in the Inspector
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player) // Check if the colliding object is the Player
        {
            Debug.Log("Player collided with checkpoint!");
            player.transform.position = targetPositionFight.position; // Move the player to the checkpoint
        }
    }
}