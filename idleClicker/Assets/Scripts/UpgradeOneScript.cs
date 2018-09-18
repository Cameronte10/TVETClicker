using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeOneScript : MonoBehaviour {
    public float upgradePrice = 50;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelOne();
    }

    public void buttonTest()
    {
        GameManagerScript.instance.GainLevelOne();

    }
}
