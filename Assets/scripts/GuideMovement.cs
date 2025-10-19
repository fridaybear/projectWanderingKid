using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class GuideMovement: MonoBehaviour
{
    public int speed = 4;
    
public GameObject cave;
    void Start()
    {
         
    }
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, cave.transform.position, speed * Time.deltaTime);   
    }
}

