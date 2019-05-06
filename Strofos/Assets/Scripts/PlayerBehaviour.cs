using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public LayerMask layer;
    private bool aboveEnemy;
    
    void Update()
    {
        Detects();
    }

    void Detects()
    {
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, GameInput.invert ? Vector2.up : Vector2.down, 1f, layer);

        if (hit.collider && hit.collider.tag.Equals("Enemy"))
        {
            aboveEnemy = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            if (aboveEnemy)
            {
                Destroy(other.gameObject);
                TimerManagement.antrian[0].time++;
            }
            else
            {
                transform.position = GameManagement.instance.lastPos;
                TimerManagement.antrian[0].time-=2;
            }
        }

        if (other.gameObject.tag.Equals("Trap"))
        {
            TimerManagement.antrian[0].time -= 2;
            transform.position = GameManagement.instance.lastPos;
        }
    }
}
