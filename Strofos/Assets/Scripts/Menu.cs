using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject credit;
    public GameObject menu;


    public void Play()
    {
        SceneManager.LoadScene("Level");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Credit()
    {
        menu.SetActive(false);
        credit.SetActive(true);
    }

    public void Back()
    {
        credit.SetActive(false);
        menu.SetActive(true);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
