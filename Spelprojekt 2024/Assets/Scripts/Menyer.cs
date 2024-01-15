using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menyer : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("World");
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void StartMeny()
    {
        SceneManager.LoadScene("StartMenu");
    }

    //PauseMenu
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
    public GameObject PauseControlUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        PauseControlUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
