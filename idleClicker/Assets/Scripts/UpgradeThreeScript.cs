using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeThreeScript : MonoBehaviour {
    private void OnMouseDown()
    {
        GameManagerScript.instance.GainLevelThree();
    }
}
