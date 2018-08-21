using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUpgradeOneScript : MonoBehaviour {
    private void OnMouseDown()
    {
        GameManagerScript.instance.GainClickLevel();
    }
}
