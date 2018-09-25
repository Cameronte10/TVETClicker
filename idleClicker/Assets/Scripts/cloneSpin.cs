using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloneSpin : MonoBehaviour {
    int random;
    public Color color;
    public Rigidbody2D rb;
    private void Start()
    {
        random = Random.Range(3, 8);
        color = GetComponent<SpriteRenderer>().color;
        rb = GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(Vector2.right * 100);
    }
    private void Update()
    {
        transform.Rotate(Vector3.forward * random);
        if(color.a <= 1)
        {
            color.a -= 0.3f * Time.deltaTime;
            this.GetComponent<SpriteRenderer>().color = color;
        }
        if (color.a <= 0)
        {
            Destroy(gameObject);
        }
    }
}

