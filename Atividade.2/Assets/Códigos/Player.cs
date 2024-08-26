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

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("Andando", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("Andando", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("Andando", false);
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!pulando)
            {
                rig.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
                puloDuplo = true;
                anim.SetBool("Pulando", true);
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
            anim.SetBool("Pulando", false);
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
