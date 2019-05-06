using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.Equals("Player"))
        {
            TimerManagement.antrian[0].time -= 2;
            other.transform.position = GameManagement.instance.lastPos;
        }
    }
}
