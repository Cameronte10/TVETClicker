﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeThreeScript : MonoBehaviour {
    public void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelThree();
    }
}
