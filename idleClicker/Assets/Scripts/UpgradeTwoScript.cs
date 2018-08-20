using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTwoScript : MonoBehaviour {
    private void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelTwo();
    }
}
