using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abacaxi : MonoBehaviour
{
    private SpriteRenderer sr;

    private CircleCollider2D circle;

    public GameObject coletado;

    public int pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            coletado.SetActive(true);

            GameController.instancia.pontuacaoTotal += pontuacao;
            
            Destroy(gameObject, 0.5f);
        }
    }
}
