using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    public Transform target; // Assign the object you want to follow

    void Update()
    {
        if (target != null)
            transform.position = target.position;
    }
}
