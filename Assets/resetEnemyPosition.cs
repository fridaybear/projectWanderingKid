using UnityEngine;
using UnityEngine.SocialPlatforms;

public class resetEnemyPosition : MonoBehaviour
{

    public Camera mainCam;
    public Vector2 defaultPosition;
    
    bool IsInView(Camera cam, Vector3 worldPosition)
    {
        Vector3 viewportPos = cam.WorldToViewportPoint(worldPosition);

        return viewportPos.z > 0 && 
            viewportPos.x > 0 && viewportPos.x < 1 && 
            viewportPos.y > 0 && viewportPos.y < 1;   
    }

    void Start()
    {
        defaultPosition = transform.position;
    }

    void Update()
    {

        if (!IsInView(mainCam, transform.position))
        {
            GetComponent<SpriteRenderer>().enabled = true;

            GetComponent<Collider2D>().enabled = true;
                
            transform.position = defaultPosition;
        }
        
    }
}
