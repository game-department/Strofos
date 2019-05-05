using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeOffset;
    public float time;
    private Timer objects;

    private void Start()
    {
        time = timeOffset;
        objects = GetComponent<Timer>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (!TimerManagement.antrian.Contains(objects)) TimerManagement.antrian.Enqueue(objects);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (TimerManagement.antrian.Contains(objects)) TimerManagement.antrian.Dequeue();
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
