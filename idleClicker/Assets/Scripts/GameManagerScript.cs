using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public Text moneyCurrentDisplay;
    public Text levelOnePrice, levelTwoPrice, levelThreePrice, levelFourPrice, levelFivePrice, clickLevelPrice;
    public Text levelOneAmount, levelTwoAmount, levelThreeAmount, levelFourAmount, levelFiveAmount, clickLevelAmount, CPS;
    public GameObject levelOnePrefab, levelTwoPrefab, levelThreePrefab, levelFourPrefab, levelFivePrefab;
    public float moneyCurrent;
    public int level1Current, level2Current, level3Current, level4Current, level5Current, clickCurrent;
    public int level1Old = 0, level2Old = 0, level3Old = 0, level4Old = 0, level5Old = 0;
    public float CPSmoney;
    public float upgrade1Price = 50;
    public float upgrade2Price = 100;
    public float upgrade3Price = 150;
    public float upgrade4Price = 200;
    public float upgrade5Price = 250;
    public float clickMultiplier = 0;
    public float clickUpgrade1Price = 200;
    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        moneyCurrentDisplay.text = "" + (int)moneyCurrent;
        levelOnePrice.text = "Level One Price: " + upgrade1Price;
        levelOneAmount.text = "" + level1Current;
        levelTwoPrice.text = "Level Two Price: " + upgrade2Price;
        levelTwoAmount.text = "" + level2Current;
        levelThreePrice.text = "Level Three Price: " + upgrade3Price;
        levelThreeAmount.text = "" + level3Current;
        levelFourPrice.text = "Level Four Price: " + upgrade4Price;
        levelFourAmount.text = "" + level4Current;
        levelFivePrice.text = "Level Five Price: " + upgrade5Price;
        levelFiveAmount.text = "" + level5Current;

        clickLevelPrice.text = "Click Level Price: " + clickUpgrade1Price;
        clickLevelAmount.text = "" + clickCurrent;

        moneyCurrent += 0.5f * level1Current * Time.deltaTime;
        moneyCurrent += 1.0f * level2Current * Time.deltaTime;
        moneyCurrent += 1.5f * level3Current * Time.deltaTime;
        moneyCurrent += 2.0f * level4Current * Time.deltaTime;
        moneyCurrent += 3.0f * level5Current * Time.deltaTime;
        CPSmoney = 0.5f * level1Current + 1.0f * level2Current + 1.5f * level3Current + 2f * level4Current + 3.0f * level5Current;
        CPS.text = "CPS: " + CPSmoney;
        
        if (level1Current > level1Old)
        {
            Instantiate(levelOnePrefab, new Vector3(Random.Range(-1.4f, 2.2f), Random.Range(-5, 5), 0), Quaternion.identity);
            level1Old++;
        }
        if (level2Current > level2Old)
        {
            Instantiate(levelTwoPrefab, new Vector3(Random.Range(-1.4f, 2.2f), Random.Range(-5, 5), 0), Quaternion.identity);
            level2Old++;
        }
        if (level3Current > level3Old)
        {
            Instantiate(levelThreePrefab, new Vector3(Random.Range(-1.4f, 2.2f), Random.Range(-5, 5), 0), Quaternion.identity);
            level3Old++;
        }
        if (level4Current > level4Old)
        {
            Instantiate(levelFourPrefab, new Vector3(Random.Range(-1.4f, 2.2f), Random.Range(-5, 5), 0), Quaternion.identity);
            level4Old++;
        }
        if (level5Current > level5Old)
        {
            Instantiate(levelFivePrefab, new Vector3(Random.Range(-1.4f, 2.2f), Random.Range(-5, 5), 0), Quaternion.identity);
            level5Old++;
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            moneyCurrent += 9999999;
        }
    }

    public void GainCurrency()
    {
        moneyCurrent += 1 + clickMultiplier;
    }

    public void GainLevelOne()
    {
        if (moneyCurrent >= upgrade1Price)
        {
            moneyCurrent -= upgrade1Price;
            level1Current += 1;
            upgrade1Price *= 1.15f;
            upgrade1Price = Mathf.RoundToInt(upgrade1Price);
            
        }
    }
    public void GainLevelTwo()
    {
        if(moneyCurrent >= upgrade2Price)
        {
            moneyCurrent -= upgrade2Price;
            level2Current++;
            upgrade2Price *= 1.4f;
            upgrade2Price =  Mathf.RoundToInt(upgrade2Price);
        }
    }
    public void GainLevelThree()
    {
        if (moneyCurrent >= upgrade3Price)
        {
            moneyCurrent -= upgrade3Price;
            level3Current++;
            upgrade3Price *= 1.60f;
            upgrade3Price =  Mathf.RoundToInt(upgrade3Price);
        }
    }
    public void GainLevelFour()
    {
        if (moneyCurrent >= upgrade4Price)
        {
            moneyCurrent -= upgrade4Price;
            level4Current++;
            upgrade4Price *= 1.80f;
            upgrade4Price = Mathf.RoundToInt(upgrade4Price);
        }
    }
    public void GainLevelFive()
    {
        if (moneyCurrent >= upgrade5Price)
        {
            moneyCurrent -= upgrade5Price;
            moneyCurrent *= 2;
            level1Current *= 2;
            level2Current *= 2;
            level3Current *= 2;
            level4Current *= 2;
            level5Current++;
            upgrade5Price *= 20;
            upgrade5Price =  Mathf.RoundToInt(upgrade5Price);
        }
    }

    public void GainClickLevel()
    {
        if(moneyCurrent >= clickUpgrade1Price)
        {
            moneyCurrent -= clickUpgrade1Price;
            clickUpgrade1Price *= 1.5f;
            clickMultiplier++;
            clickUpgrade1Price = Mathf.Round(clickUpgrade1Price);
            clickCurrent++;
        }
    }





}

