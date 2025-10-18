using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class EnemyTracking : MonoBehaviour
{
    public int speed = 2;
    public GameObject player;
    public GameObject enemy;

    void Start()
    {
        player = GameObject.Find("player");
        enemy = GameObject.Find("enemy");      
    }
    void Update()
    {
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
