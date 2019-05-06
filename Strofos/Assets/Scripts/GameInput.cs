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

    private SpriteRenderer[] image;
    
    
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        image = GetComponentsInChildren<SpriteRenderer>();
    }


    void Update()
    {
        if (GameVariables.freeze) return;
        Move();
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
        float move = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        image[0].flipX = move > 0 ? false : (move < 0 ? true : false);
        image[1].flipX = move > 0 ? false : (move < 0 ? true : false);
        /*if (invert)
        {
            move *= -1;
        }*/
        transform.Translate(move, 0, 0);
    }

    public void changeGravity()
    {
        rigidBody.gravityScale = invert ? -1 : 1;
        image[0].flipY = invert;
        image[1].flipY = invert;
    }
}
