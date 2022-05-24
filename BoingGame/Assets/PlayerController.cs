using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    public float force;

    public bool start;
    public bool isFalling;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        // JUMP ANÝMATÝON CONTROLÝNG BY VELOCÝTY
        if (rb.velocity.y < 0)
        {
            anim.SetBool("isJumping", false);
        }
        else if (rb.velocity.y > 0)
        {
            anim.SetBool("isJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

       if (collision.gameObject.tag == "Platform" && start)
        {
            rb.AddForce(Vector2.up * force);
            isFalling = false;
        }
    }


    public void Fall()
    {
        if (!isFalling && start)
        {
            rb.AddForce(Vector2.down * force);
            isFalling = true;
        }

        if (!start) runGame();

    }

   public void runGame()
    {
        rb.AddForce(Vector2.up * force);
        start = true;
    }

}
