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

    void Update()
    {

        float step = speed * Time.deltaTime;
        if(transform.position.x == targetB.x)
        {
            vector = A.transform.position;
        }
        else if(transform.position.x == targetA.x)
        {
            vector = B.transform.position;
        }
        transform.position = Vector2.MoveTowards(transform.position, vector, step);
    }
}
