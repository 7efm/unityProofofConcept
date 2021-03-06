﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    void Start()
    {
        health = GlobalControl.Instance.health;
        numHearts = GlobalControl.Instance.numHearts;

    }
    void Update()
    {

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        
    }
    public void SavePlayer()
    {
        GlobalControl.Instance.health = health;
        GlobalControl.Instance.numHearts = numHearts;

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("HealthDecrease"))
        {
            Debug.Log("hit");
            health--;
            SavePlayer();
        }

    }
}
