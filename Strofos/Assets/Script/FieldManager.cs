using System.Linq;
using UnityEngine;

public class FieldManager : MonoBehaviour
{
    [SerializeField] private float timeOffset;
    public float time;
    private FieldManager objects;

    public bool invertable;

    private void Start()
    {
        time = timeOffset;
        objects = GetComponent<FieldManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (!TimerManagement.antrian.Contains(objects)) TimerManagement.antrian.Add(objects);
            if (!InvertManagement.antrian.Contains(objects)) InvertManagement.antrian.Add(objects); 
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (TimerManagement.antrian.Contains(objects)) TimerManagement.antrian.Remove(objects);
            if (InvertManagement.antrian.Contains(objects)) InvertManagement.antrian.Remove(objects);
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
