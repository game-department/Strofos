using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timer;
    public float [] timeCount = new float[4]
    {
        10,10,10,10
    };

    void Update()
    {

    }

    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag.Equals("Player"))
    //    {
    //        isPlayer = true;
    //    }
    //}

    public void OnTriggerStay2D(Collider2D collision)
    {
        float counter;
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (this.tag.Equals("B1"))
            {
                timeCount[0] -= 0.01f;
                counter = Mathf.Round(timeCount[0]);
                timer.text = counter.ToString();
            }
            if (this.tag.Equals("B2"))
            {
                timeCount[1] -= 0.01f;
                counter = Mathf.Round(timeCount[1]);
                timer.text = counter.ToString();
            }
            if (this.tag.Equals("B3"))
            {
                timeCount[2] -= 0.01f;
                counter = Mathf.Round(timeCount[2]);
                timer.text = counter.ToString();
            }
            if (this.tag.Equals("B4"))
            {
                timeCount[3] -= 0.01f;
                counter = Mathf.Round(timeCount[3]);
                timer.text = counter.ToString();
            }
        }
    }
}


//void decreaseTime()
//{
//    float counter;
//    if (isPlayer)
//    {
//        if (this.tag.Equals("B1"))
//        {
//            timeCount[0] -= 0.01f;
//            counter = Mathf.Round(timeCount[0]);
//            timer.text = counter.ToString();
//        }
//        if (this.tag.Equals("B2"))
//        {
//            timeCount[1] -= 0.01f;
//            counter = Mathf.Round(timeCount[1]);
//            timer.text = counter.ToString();
//        }
//        if (this.tag.Equals("B3"))
//        {
//            timeCount[2] -= 0.01f;
//            counter = Mathf.Round(timeCount[2]);
//            timer.text = counter.ToString();
//        }
//        if (this.tag.Equals("B4"))
//        {
//            timeCount[3] -= 0.01f;
//            counter = Mathf.Round(timeCount[3]);
//            timer.text = counter.ToString();
//        }
//    }
