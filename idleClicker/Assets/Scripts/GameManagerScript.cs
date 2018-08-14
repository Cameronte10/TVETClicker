using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public Text moneyCurrentDisplay;
    public Text levelOnePrice;
    public Text levelOneAmount;
    public float moneyCurrent;
    public int level1Current;
    public float upgrade1Price = 50;
    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        moneyCurrentDisplay.text = "Cowoncy: " + moneyCurrent;
        levelOnePrice.text = "Level One Price: " + upgrade1Price;
        levelOneAmount.text = "" + level1Current;
    }

    public void GainCurrency()
    {
        moneyCurrent += 1 + level1Current;

    }

    public void GainLevelOne()
    {
        if (moneyCurrent >= upgrade1Price)
        {
            moneyCurrent -= upgrade1Price;
            level1Current += 1;
            upgrade1Price += 10;
        }
    }
    public void GainLevelTwo()
    {

    }
}

