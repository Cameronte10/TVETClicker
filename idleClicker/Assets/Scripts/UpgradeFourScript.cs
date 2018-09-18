using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFourScript : MonoBehaviour {
    public void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelFour();
    }
}
