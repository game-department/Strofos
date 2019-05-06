﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishManagement : MonoBehaviour
{
    public string sceneDirect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            SceneManager.LoadScene(sceneDirect);
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
    }
}
