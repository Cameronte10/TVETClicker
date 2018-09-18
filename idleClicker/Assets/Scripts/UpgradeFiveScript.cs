using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFiveScript : MonoBehaviour {
    public void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelFive();
    }
}
