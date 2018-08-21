using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
    int random;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OutOfBounds"))
        {
            transform.position = new Vector3(Random.Range(-7f, 7f), 7, 0);
        }
    }
    private void Start()
    {
        random = Random.Range(3, 8);
    }
    private void Update()
    {
        transform.Rotate(Vector3.forward * random);
    }
}
