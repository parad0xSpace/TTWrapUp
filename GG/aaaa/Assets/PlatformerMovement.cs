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
    public static bool change = false;

    void Start()
    {

    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
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
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == groundLayer)
        {
            grounded = true;
            jumpCount = 0;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == groundLayer)
        {
            grounded = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "levelChanger")
        {
            change = true;
        }
    }
}

