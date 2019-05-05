using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public static bool isPause = false;
    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                Resume();
            }
            else
            {
                PauseMenu();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }

    public void PauseMenu()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
}
