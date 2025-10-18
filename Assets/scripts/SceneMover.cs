using System;
using UnityEngine;
using UnityEngine.Rendering;

public class sceneadjuster : MonoBehaviour
{

    [SerializeField] Camera SceneCamera;
    [SerializeField] GameObject player;

    public int XaxisOffset = 22;
    public int YaxisOffset = 10;


    void Start()
    {
        player = transform.Find("player").gameObject;

    }

    void isPlayerInView(Camera cam, Vector3 playerPosition)
    {

        Vector3 viewportPoint = cam.WorldToViewportPoint(playerPosition);

        if (viewportPoint.x < 0) 
        {
            SceneCamera.transform.position += new Vector3(-XaxisOffset,0,0);
        }
        if (viewportPoint.x > 1)
        {
            SceneCamera.transform.position += new Vector3(XaxisOffset,0,0);
        }
        if (viewportPoint.y < 0) 
        {
            SceneCamera.transform.position += new Vector3(0,-YaxisOffset,0);
        }
        if (viewportPoint.y > 1) 
        {
            SceneCamera.transform.position += new Vector3(0,YaxisOffset,0);
        }

    }

    void Update()
    {
        isPlayerInView(SceneCamera,player.transform.position);
    }
}
