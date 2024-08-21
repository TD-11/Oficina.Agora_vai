using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float velocidade;
    public float forcaPulo;
    public bool pulando;
    public bool puloDuplo;

    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movimento * Time.deltaTime * velocidade;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!pulando)
            {
                rig.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
                puloDuplo = true;
            }
            else
            {
                if (puloDuplo)
                {
                    rig.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
                    puloDuplo = false;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            pulando = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            pulando = true;
        }
    }
}
