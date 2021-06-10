using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    public bool grounded = false;
    public int groundLayer = 0;
    public int maxJump = 2;
    int jumpCount = 0;
    //Animator anim;
    float moveX;

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;

        if(Input.GetButtonDown("Jump") && grounded)
        {
            Jump();
        }
        else if (Input.GetButtonDown("Jump") && jumpCount <= maxJump)
        {
            Jump();
        }

        float x = Input.GetAxisRaw("Horizontal");
        if(x == 0)
        {
            //anim.SetInteger("x", 0);
        }
        else
        {
            //anim.SetInteger("x", 1);
        }

        if(velocity.y < 0)
        {
            //anim.SetInteger("y", -1);
        }
        else if (velocity.y > 0)
        {
            //anim.SetInteger("y", 1);
        }
        else
        {
            //anim.SetInteger("y", 0);
        }

        if(x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        jumpCount++;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == groundLayer)
        {
            grounded = true;
            jumpCount = 0;
            //anim.SetBool("grounded", grounded);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == groundLayer)
        {
            grounded = true;
            jumpCount = 0;
            //anim.SetBool("grounded", grounded);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == groundLayer)
        {
            grounded = false;
            //anim.SetBool("grounded", grounded);
        }
    }

    public void MoveLeft()
    {
        moveX = -1;
    }

    public void MoveRight()
    {
        moveX = 1;
    }

    public void StopIt()
    {
        moveX = 0;
    }
}

