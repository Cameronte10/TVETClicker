using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public Text moneyCurrentDisplay;
    public Text levelOnePrice, levelTwoPrice, levelThreePrice, levelFourPrice, levelFivePrice;
    public Text levelOneAmount, levelTwoAmount, levelThreeAmount, levelFourAmount, levelFiveAmount;
    public float moneyCurrent;
    public int level1Current, level2Current, level3Current, level4Current, level5Current;
    public float upgrade1Price = 50;
    public float upgrade2Price = 100;
    public float upgrade3Price = 150;
    public float upgrade4Price = 200;
    public float upgrade5Price = 250;
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
        levelTwoPrice.text = "Level Two Price " + upgrade2Price;
        levelTwoAmount.text = "" + level2Current;
        levelThreePrice.text = "Level Three Price " + upgrade3Price;
        levelThreeAmount.text = "" + level3Current;
        levelFourPrice.text = "Level Four Price " + upgrade4Price;
        levelFourAmount.text = "" + level4Current;
        levelFivePrice.text = "Level Five Price " + upgrade5Price;
        levelFiveAmount.text = "" + level5Current;
        moneyCurrent += 0.0045f * level2Current;
        moneyCurrent += 0.01f * level3Current;
        moneyCurrent += 0.018f * level4Current;
        moneyCurrent += 0.035f * level5Current;
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
        if(moneyCurrent >= upgrade2Price)
        {
            moneyCurrent -= upgrade2Price;
            level2Current++;
            upgrade2Price += 15;
        }
    }
    public void GainLevelThree()
    {
        if (moneyCurrent >= upgrade3Price)
        {
            moneyCurrent -= upgrade3Price;
            level3Current++;
            upgrade3Price += 30;
        }
    }
    public void GainLevelFour()
    {
        if (moneyCurrent >= upgrade4Price)
        {
            moneyCurrent -= upgrade4Price;
            level4Current++;
            upgrade4Price += 40;
        }
    }
    public void GainLevelFive()
    {
        if (moneyCurrent >= upgrade5Price)
        {
            moneyCurrent -= upgrade5Price;
            level5Current++;
            upgrade5Price += 55;
        }
    }

}

