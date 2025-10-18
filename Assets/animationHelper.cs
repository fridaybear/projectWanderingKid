using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpriteChange : MonoBehaviour
{
    public Sprite[] sprites; // Drag all sliced frames here (from your sprite sheet)
    private SpriteRenderer sr;

    public int animationCycle = 0;
    public int idleStates = 0;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            if (animationCycle == 0)
            {
                sr.sprite = sprites[4];
                animationCycle = 1;
                idleStates = 0;
            }
            else
            {
                sr.sprite = sprites[5];
                animationCycle = 0;
                idleStates = 0;
            }
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            if (animationCycle == 0)
            {
                sr.sprite = sprites[1];
                animationCycle = 1;
                idleStates = 1;
            }
            else
            {
                sr.sprite = sprites[2];
                animationCycle = 0;
                idleStates = 1;
            }
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            if (animationCycle == 0)
            {
                sr.sprite = sprites[7];
                animationCycle = 1;
                idleStates = 2;
            }
            else
            {
                sr.sprite = sprites[8];
                animationCycle = 0;
                idleStates = 2;
            }
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            if (animationCycle == 0)
            {
                sr.sprite = sprites[10];
                animationCycle = 1;
                idleStates = 3;
            }
            else
            {
                sr.sprite = sprites[11];
                animationCycle = 0;
                idleStates = 4;
            }     
        }
        else
        {
            if (idleStates == 0)
            {
                sr.sprite = sprites[3];
            }
            else if (idleStates == 1)
            {
                sr.sprite = sprites[0];
            } else if (idleStates == 2)
            {
                sr.sprite = sprites[6];
            } else if (idleStates == 3)
            {
                sr.sprite = sprites[9];
            }
        }
    }
}
