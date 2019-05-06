using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldManager : MonoBehaviour
{
    [SerializeField] private float timeOffset;
    public float time;
    private FieldManager objects;

    public bool invertable;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void Start()
    {
        time = timeOffset;
        objects = GetComponent<FieldManager>();
    }

    private bool toggle;
    private void Update()
    {
        if (!toggle)
        {
            toggle = true;
            objects = GetComponent<FieldManager>();
        }
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

    void Reset()
    {
        time = timeOffset;
        toggle = false;
        GameInput.invert = false;
        TimerManagement.antrian = new List<FieldManager>();
        InvertManagement.antrian = new List<FieldManager>();
    }
    
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Level")
        {
            Reset();
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
