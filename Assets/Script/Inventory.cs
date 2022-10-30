using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int coinsCount;
    public Text coinsCountTxt;

    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance d'inventaire");
        }
        instance = this;
    }

    public void AddCoins(int coins)
    {
        coinsCount += coins;
        coinsCountTxt.text = coinsCount.ToString();
    }
}
