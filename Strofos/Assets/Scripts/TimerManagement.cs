using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManagement : MonoBehaviour
{
    public Text timer;
    public static List<FieldManager> antrian = new List<FieldManager>();
    
    void Update()
    {
        if (!(antrian.Count == 0))
        {
            antrian[0].time -= Time.deltaTime;
            timer.text = "" + Mathf.Ceil(antrian[0].time);
        }
    }
}
