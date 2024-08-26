using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abacaxi : MonoBehaviour
{
    private SpriteRenderer sr;

    private CircleCollider2D cicle;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        cicle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
