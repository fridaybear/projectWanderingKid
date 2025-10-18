using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class EnemyTracking : MonoBehaviour
{
    public int speed = 2;
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("player");    
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
