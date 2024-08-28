using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma_falsa : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempoQueda;
    private TargetJoint2D target;
    private BoxCollider2D bc;
    
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Queda", tempoQueda);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
        
    }

    void Queda()
    {
        target.enabled = false;
        bc.isTrigger = true;
    }
}
