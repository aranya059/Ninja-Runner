﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject pauseMenu;
    public static bool isPaused;
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }
    public void onUserClickStart()
    {
        //SceneManager.LoadScene(1);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale=0f;
        isPaused = true;
    }
    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void mainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
