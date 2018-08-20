using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFiveScript : MonoBehaviour {
    private void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelFive();
    }
}
