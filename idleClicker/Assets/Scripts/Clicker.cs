using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public int randomZ;
    public GameObject clone;
    public float minScale;
    public float maxScale;
    public bool clicked;
    public bool currentScaleMin;
    public Vector3 spawnPOS;
    private void OnMouseDown()
    {
        GameManagerScript.instance.GainCurrency();
        clicked = true;
        randomZ = Random.Range(0, 360);
        Instantiate(clone, spawnPOS, Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, randomZ)));
    }
    private void Update()
    {
        if (clicked==true)
        {
            Scale();
        }
    }
    private void Scale()
    {
        if (transform.localScale.x > minScale && currentScaleMin == false)
        {
            transform.localScale = new Vector2(transform.localScale.x - 0.1f, transform.localScale.y - 0.1f);

        }
        else
        {
            currentScaleMin = true;
        }
        if (currentScaleMin == true)
        {
            transform.localScale = new Vector2(transform.localScale.x + 0.1f, transform.localScale.y + 0.1f);
        }
        if (transform.localScale.x == maxScale)
        {
            clicked = false;
            currentScaleMin = false;
        }
    }
}
