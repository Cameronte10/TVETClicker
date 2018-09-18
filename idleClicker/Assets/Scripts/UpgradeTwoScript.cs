using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTwoScript : MonoBehaviour {
    public void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelTwo();
    }
}
