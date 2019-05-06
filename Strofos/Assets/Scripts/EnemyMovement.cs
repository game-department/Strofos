using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private float speed = 10f;

    private Vector2 targetA;
    private Vector2 targetB;
    private Vector2 currentPos;

    public GameObject A;
    public GameObject B;

    public Vector2 vector;

    private SpriteRenderer image;

    private void Start()
    {
        image = GetComponent<SpriteRenderer>();
        targetA.x = A.transform.position.x;
        targetB.x = B.transform.position.x;
    }

    void Update()
    {

        float step = speed * Time.deltaTime;
        if(transform.position.x == targetB.x)
        {
            image.flipX = true;
            vector = A.transform.position;
        }
        else if(transform.position.x == targetA.x)
        {
            image.flipX = false;
            vector = B.transform.position;
        }
        transform.position = Vector2.MoveTowards(transform.position, vector, step);
    }
}
