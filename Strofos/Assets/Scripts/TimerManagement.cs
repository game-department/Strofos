using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManagement : MonoBehaviour
{
    public Text timer;
    public Image image;
    public static List<FieldManager> antrian = new List<FieldManager>();
    
    void Update()
    {
        if (!(antrian.Count == 0) && !GameVariables.lose)
        {
            antrian[0].time -= Time.deltaTime;
            if (antrian[0].time < 0)
            {
                antrian[0].time = 0;
                GameVariables.lose = true;
            }
            timer.text = "" + Mathf.Ceil(antrian[0].time);

             
            if (GameInput.invert)
            {
                image.color = Color.white;
                timer.color = Color.black;
            }
            else
            {
                image.color = Color.black;
                timer.color = Color.white;
            }
        }
    }
}
