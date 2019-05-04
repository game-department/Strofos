using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public bool invert;

    public Vector2 direction;

    private Rigidbody2D rigidBody;
    public LayerMask layer;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
        Move();
    }

    bool isGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, Vector2.down, 1f, layer);

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
                    rigidBody.AddForce(Vector2.up * jumpForce);
                }
            }

        }
    }

    void Move()
    {
        direction = Vector2.zero;
        if (!invert)
        {
            if (Input.GetKey(KeyCode.D))
            {
                direction = Vector2.right;
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction = Vector2.left;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
                direction = Vector2.left;
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction = Vector2.right;
            }
        }
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void OnColliderStay(Collider other)
    {
        if (other.gameObject.layer.Equals("Background_White"))
        {
            invert = false;
        }
        else if (other.gameObject.layer.Equals("Background_Black"))
        {
            invert = true;
        }
    }
}
