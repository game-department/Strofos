using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManagement : MonoBehaviour
{
    public Text timer;
    public static Queue<Timer> antrian = new Queue<Timer>();
    
    void Update()
    {
        if (!(antrian.Count == 0))
        {
            antrian.Peek().time -= Time.deltaTime;
            timer.text = "" + Mathf.Ceil(antrian.Peek().time);
        }
    }
}
