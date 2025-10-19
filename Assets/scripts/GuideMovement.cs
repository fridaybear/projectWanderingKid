using UnityEngine;
using System.Collections;

public class GuideMovement : MonoBehaviour
{
    public int speed = 3;

    public Sprite[] sprites; // Drag all sliced frames here (from your sprite sheet)
    private SpriteRenderer sr;

    public int animationCycle = 0;

    public GameObject cave;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(DoSomethingWithDelay());
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cave.transform.position, speed * Time.deltaTime);
    }

    private IEnumerator DoSomethingWithDelay()
    {
        while (true)
        {
            if (animationCycle == 0)
            {
                sr.sprite = sprites[0];
                animationCycle = 1;
            }
            else
            {
                sr.sprite = sprites[1];
                animationCycle = 0;
            }

            yield return new WaitForSeconds(0.2f); // Wait after each frame swap
        }
    }
}