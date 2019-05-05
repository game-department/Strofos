using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timer;
    public float timeCount;
    private float output;

    public bool isPlayer;

    void Update()
    {
        timer.text = output.ToString();
        decreaseTime();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            isPlayer = true;
        }
    }

    void decreaseTime()
    {
        if (isPlayer)
        {
            timeCount -= 0.01f;
            output = Mathf.Round(timeCount);
        }
    }

}
