using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{

    public static GameManagement instance;

    public GameObject fadeIn;
    public GameObject fadeOut;

    public Vector2 lastPos;
    
    // Start is called before the first frame update
    void Awake()
    {
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        GameVariables.freeze = true;
        instance = this;
    }
    
    

    private void Start()
    {
        
        StartCoroutine("DelayFadeOut");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    IEnumerator DelayFadeOut()
    {
        yield return new WaitForSeconds(1);
        fadeOut.SetActive(false);
        GameVariables.freeze = false;
        GameVariables.lose = false;
        toggle = false;
    }
    
    IEnumerator DelayFadeIn()
    {
        fadeIn.SetActive(true);
        GameVariables.freeze = true;
        yield return new WaitForSeconds(1);

        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("ComingSoon");
    }


    private bool toggle;
    // Update is called once per frame
    void Update()
    {
        if (GameVariables.lose && !toggle && !GameVariables.freeze)
        {
            toggle = true;
            StartCoroutine("DelayFadeIn");
        }
    }
    
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Level")
        {
            Time.timeScale = 1;
        }
    }
}
