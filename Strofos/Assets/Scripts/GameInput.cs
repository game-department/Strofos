using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public static bool invert;

    public Vector2 direction;

    private Rigidbody2D rigidBody;
    public LayerMask layer;
    
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        changeGravity();
        Jump();
    }

    bool isGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, invert ? Vector2.up : Vector2.down, 0.7f, layer);

        if (hit)
        {
            return true;
        }
        return false;
    }

    void Jump()
    {
        if (isGround())
        {
            if (!invert)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    rigidBody.AddForce(Vector2.up * jumpForce);
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    rigidBody.AddForce(Vector2.down * jumpForce);
                }
            }

        }
    }

    void Move()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        /*if (invert)
        {
            move *= -1;
        }*/
        transform.Translate(move, 0, 0);
    }

    public void changeGravity()
    {
        rigidBody.gravityScale = invert ? -1 : 1;
    }


    /*public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hi");
        if (other.gameObject.layer.Equals("Background_White"))
        {
            invert = false;
        }
        else if (other.gameObject.layer.Equals("Background_Black"))
        {
            invert = true;
        }
    }*/
}
