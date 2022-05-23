using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D collider;
    public float force;

    private float speed = 1;
    private bool start;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();

    }


    private void FixedUpdate()
    {
        if (start) transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);

    }


    private void OnMouseUp()
    {
        if (!start) rb.AddForce(Vector2.up * force);

        start = true;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

       if (collision.gameObject.tag == "Platform" && start)
        {
            rb.AddForce(Vector2.up * force);
        }
    }

   

}
