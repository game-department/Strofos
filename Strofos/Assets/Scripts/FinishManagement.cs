using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishManagement : MonoBehaviour
{
    public string sceneDirect;
    private bool toggle;
    
    private void Start()
    {
        toggle = false;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player") && !toggle)
        {
            toggle = true;
            GameVariables.freeze = true;
            StartCoroutine("Delay");
        }
    }

    IEnumerator Delay()
    {
        GameManagement.instance.fadeIn.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneDirect);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Level")
        {
            toggle = false;
        }
    }
}
