using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFourScript : MonoBehaviour {
    private void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelFour();
    }
}
