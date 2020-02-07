﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;
    
    private void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void Addstars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void Spendstars(int amount)
    {
        if (stars >= amount) 
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
}
