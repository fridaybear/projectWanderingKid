using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;



public class Health : MonoBehaviour
{
    public int currentHealth;
    public int Numofhearts;

    public Image[] hearts;
    public Sprite fullheart;

    public Sprite emptyheart;

public void UpdateHearts(int health)
{
    currentHealth = health;
}


    void Update()
    {
        if (currentHealth > Numofhearts)
        {
            currentHealth = Numofhearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullheart;
            }
            else
            {
                hearts[i].sprite = emptyheart;
            }
            if (i < Numofhearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }


        }
    }

}


