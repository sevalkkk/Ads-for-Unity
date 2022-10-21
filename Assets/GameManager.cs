using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI currentCoinText;
    int coins = 0;


    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
   
    public void RewardUser()
    {
        coins += 100;
        UpdateCoins();
    }

    public void UpdateCoins()
    {
        currentCoinText.text = coins.ToString();
    }
}
